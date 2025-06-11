using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class MySqlRepository
{
    private readonly string _connectionString;

    public MySqlRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<SupportCase> CarregarCasos()
    {
        var casos = new List<SupportCase>();

        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        // 1ª etapa: carregar os casos
        var cmd = new MySqlCommand("SELECT id, descricao, solucao FROM casos", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            casos.Add(new SupportCase
            {
                Id = reader.GetInt32(0),
                Problem = reader.GetString(1),
                Solution = reader.GetString(2),
                ImagensBase64 = new List<string>()
            });
        }
        reader.Close(); // <-- Fechar o DataReader para poder usar outro comando na mesma conexão

        // 2ª etapa: carregar as imagens de cada caso
        foreach (var caso in casos)
        {
            var imgCmd = new MySqlCommand("SELECT imagem_base64 FROM caso_imagens WHERE caso_id = @id", conn);
            imgCmd.Parameters.AddWithValue("@id", caso.Id);
            using var imgReader = imgCmd.ExecuteReader();
            while (imgReader.Read())
            {
                caso.ImagensBase64.Add(imgReader.GetString(0));
            }
            imgReader.Close();
        }

        return casos;
    }

    public bool ValidarUsuario(string usuario, string senha, out string nome, out string perfil)
    {
        nome = null;
        perfil = null;

        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        var cmd = new MySqlCommand("SELECT nome, perfil FROM usuarios WHERE usuario = @usuario AND senha = @senha", conn);
        cmd.Parameters.AddWithValue("@usuario", usuario);
        cmd.Parameters.AddWithValue("@senha", senha);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            nome = reader.GetString(0);
            perfil = reader.GetString(1);
            return true;
        }

        return false;
    }
    public void InserirCaso(SupportCase caso)
    {
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        using var trans = conn.BeginTransaction();

        var cmd = new MySqlCommand("INSERT INTO casos (descricao, solucao) VALUES (@d, @s); SELECT LAST_INSERT_ID();", conn, trans);
        cmd.Parameters.AddWithValue("@d", caso.Problem);
        cmd.Parameters.AddWithValue("@s", caso.Solution);
        int novoId = Convert.ToInt32(cmd.ExecuteScalar());

        foreach (var base64 in caso.ImagensBase64)
        {
            var imgCmd = new MySqlCommand("INSERT INTO caso_imagens (caso_id, imagem_base64) VALUES (@id, @img)", conn, trans);
            imgCmd.Parameters.AddWithValue("@id", novoId);
            imgCmd.Parameters.AddWithValue("@img", base64);
            imgCmd.ExecuteNonQuery();
        }

        trans.Commit();
    }
    public void RegistrarLog(string usuario, string problema, string resultado, float similaridade)
    {
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        var cmd = new MySqlCommand("INSERT INTO log_pesquisa (usuario, problema_pesquisado, resultado_sugerido, similaridade) VALUES (@u, @p, @r, @s)", conn);
        cmd.Parameters.AddWithValue("@u", usuario);
        cmd.Parameters.AddWithValue("@p", problema);
        cmd.Parameters.AddWithValue("@r", resultado);
        cmd.Parameters.AddWithValue("@s", similaridade);
        cmd.ExecuteNonQuery();
    }





}
