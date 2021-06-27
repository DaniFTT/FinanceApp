using FinanceApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Utilities
{
    public static class JsonHandler
    {
        private static StreamReader sr;



        #region Listar Dados JSON
        public static List<Integrante> ListaDeIntegrantes()
        {
            List<Integrante> integrantes = new List<Integrante>();
            if (File.Exists(RetornaFilePath("Integrantes")))
            {
                sr = new StreamReader(RetornaFilePath("Integrantes"), true);
                string json = sr.ReadToEnd();

                sr.Dispose();

                if (json.Length > 1)
                {
                    integrantes = JsonConvert.DeserializeObject<List<Integrante>>(json);
                }
            }
            return integrantes;
        }

        public static List<Produto> ListaDeProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            if (File.Exists(RetornaFilePath("ProdutosMercado")))
            {
                sr = new StreamReader(RetornaFilePath("ProdutosMercado"), true);
                string json = sr.ReadToEnd();

                sr.Dispose();

                if (json.Length < 1)
                {
                    return produtos;
                }

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                produtos = JsonConvert.DeserializeObject<List<Produto>>(json, settings);
            }
            return produtos;
        }

        #endregion

        #region Salvar Dados JSON
        public static void SalvarDados(List<Integrante> integrantes)
        {
            var json = JsonConvert.SerializeObject(integrantes, Formatting.Indented);
            File.WriteAllText(RetornaFilePath("Integrantes"), json);
        }

        public static void SalvarDados(List<Produto> produtos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            var json = JsonConvert.SerializeObject(produtos, Formatting.Indented, settings);
            File.WriteAllText(RetornaFilePath("ProdutosMercado"), json);
        }

        #endregion

        public static string RetornaFilePath(string arquivo)
        {
            return $"{Environment.CurrentDirectory}\\files\\{arquivo}.json";
        }
    }
}
