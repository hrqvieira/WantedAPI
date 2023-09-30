using HTTPCLIENT.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;

namespace HTTPCLIENT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WantedController : Controller
    {
        private AppDbContext _context;
        public WantedController(AppDbContext context)
        {
            _context = context;
        }

        //Consutando API do FBI e salvando lista no Banco
        [HttpGet("fbi")]
        public List<Wanted> GetFBI(string page)
        {
            var client = new HttpClient();

            var endpoint = new Uri($"https://api.fbi.gov/wanted/v1/list?page={page}&pageSize=10");
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            var list = new List<Wanted>();

            foreach (var item in obj.items)
            {
                if (item.poster_classification != "default" && item.poster_classification != "missing")
                {
                    list.Add(new Wanted
                    {
                        Name = item.title,
                        Crime = item.poster_classification,
                        Nationality = item.nationality,
                        Sex = item.sex,
                        Hair = item.hair,
                        ScarsAndMarks = item.scars_and_marks,
                        Eyes = item.eyes,
                        WantedDescription = item.description,
                        Warning_message = item.warning_message,
                    });
                }
            }


            _context.Wanteds.AddRange(list);
            _context.SaveChanges();

            return list;
        }


        //Consultando api da interpool e salvando no banco
        [HttpGet("intepool")]
        public List<Wanted> GetInterpool(string page)
        {
            var client = new HttpClient();


            var endpoint = new Uri($"https://ws-public.interpol.int/notices/v1/red?page={page}&resultPerPage=20");
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            var list = new List<Wanted>();

            foreach (var item in obj._embedded.notices)
            {
                list.Add(new Wanted
                {
                    Name = item.name,
                    BirthDate = item.date_of_birth,
                });
            }

            _context.Wanteds.AddRange(list);
            _context.SaveChanges();

            return list;
        }


        //Endpoint que retorna todos os procurados
        [HttpGet("procurados")]
        public ActionResult<IEnumerable<Wanted>> GetWanteds()
        {
            var wanteds = _context.Wanteds.AsNoTracking().ToList();
            if (wanteds is null)
            {
                return NotFound();
            }

            return wanteds;
        }


        //Endpoint que retorna um procurado pelo ID
        [HttpGet("{id:int}", Name = "id")]
        public ActionResult<Wanted> GetForId(int id)
        {
            var wanted = _context.Wanteds.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (wanted is null)
            {
                return NotFound();
            }
            return wanted;
        }


        //Endpoint que retorna um procurado pelo nome
        [HttpGet("{name}", Name = "name")]
        public ActionResult<Wanted> GetForName(string name)
        {
            var wanted = _context.Wanteds.AsNoTracking().FirstOrDefault(p => p.Name == name);
            if (wanted is null)
            {
                return NotFound();
            }
            return wanted;
        }

    }
}
