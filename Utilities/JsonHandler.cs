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

        #endregion

        #region Salvar Dados JSON

        public static void SalvarDados(List<Integrante> integrantes)
        {
            var json = JsonConvert.SerializeObject(integrantes, Formatting.Indented);
            File.WriteAllText(RetornaFilePath("Integrantes"), json);
        }

        #endregion

        public static string RetornaFilePath(string arquivo)
        {
            return $"{Environment.CurrentDirectory}\\files\\{arquivo}.json";
        }
    }
}
