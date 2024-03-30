using Dominio.Interfaces;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class ServicoFilmes : IServicoFilmes
    {
        public async Task<IEnumerable<Filme>> ObterFilmes()
        {
            IEnumerable<Filme> retorno;
            using (var client = new HttpClient())
            {
                using (var api = await client.GetAsync("https://l3-processoseletivo.azurewebsites.net/api/Competidores?copa=filmes"))
                {
                    var apiResult = await api.Content.ReadAsStringAsync();
                    retorno = JsonConvert.DeserializeObject<IEnumerable<Filme>>(apiResult);
                }

                return retorno;

            }
        }

    }
}
