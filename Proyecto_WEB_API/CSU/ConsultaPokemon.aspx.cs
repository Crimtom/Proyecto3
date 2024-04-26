using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;
using Proyecto_WEB_API.CSD;

namespace Proyecto_WEB_API.CSU
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            string Respuesta;

            RestRequest request = new RestRequest();
            var response = client.Get(request);

            Respuesta = response.Content;

            Resultados_Pokemon oResultados = JsonConvert.DeserializeObject <Resultados_Pokemon>(Respuesta);

            Pokemon oPokemon = oResultados.Pokemons[0];

            img_pokemon_sprite.ImageUrl = oPokemon.sprites.front_default;

            Label1.Text = oPokemon.name;
        }
    }
}