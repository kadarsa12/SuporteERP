using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;

public class CaseRecommender
{
    private MLContext mlContext;
    private ITransformer model;
    private List<SupportCase> baseCases;
    private List<SupportCaseTfidf> caseVectors;
    private List<string> casos;

    public CaseRecommender(List<SupportCase> cases)
    {
        mlContext = new MLContext();
        baseCases = cases;

        // Converter para formato simples aceito pelo ML.NET
        var mlCases = cases.Select(c => new SupportCaseML
        {
            Problem = c.Problem,
            Solution = c.Solution
        });

        var data = mlContext.Data.LoadFromEnumerable(mlCases);

        var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(SupportCaseML.Problem));
        model = pipeline.Fit(data);
        var transformedData = model.Transform(data);
        caseVectors = mlContext.Data.CreateEnumerable<SupportCaseTfidf>(transformedData, reuseRowObject: false).ToList();
    }

    public CaseRecommender(List<string> casos)
    {
        this.casos = casos;
    }

    public string GetBestMatch(string inputProblem, out float similarity)
    {
        var input = new List<SupportCaseML> { new SupportCaseML { Problem = inputProblem } };
        var inputData = mlContext.Data.LoadFromEnumerable(input);
        var transformed = model.Transform(inputData);
        var inputVector = mlContext.Data.CreateEnumerable<SupportCaseTfidf>(transformed, reuseRowObject: false).First().Features;

        float CosineSimilarity(float[] a, float[] b)
        {
            float dot = 0, normA = 0, normB = 0;
            for (int i = 0; i < a.Length; i++)
            {
                dot += a[i] * b[i];
                normA += a[i] * a[i];
                normB += b[i] * b[i];
            }
            return (float)(dot / (Math.Sqrt(normA) * Math.Sqrt(normB)));
        }

        var result = baseCases
            .Select((c, idx) => new { c.Solution, Sim = CosineSimilarity(inputVector, caseVectors[idx].Features) })
            .OrderByDescending(x => x.Sim)
            .First();

        similarity = result.Sim;
        return result.Solution;
    }
}

