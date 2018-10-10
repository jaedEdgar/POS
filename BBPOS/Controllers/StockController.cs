using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock;
namespace BBPOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        // GET: api/Stock
        [HttpGet]
        public List<Drug> Get()
        {
            return this.fakeData(0,0);

        }

        // GET: api/Stock/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST: api/Stock
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stock/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public List<Drug> fakeData()
        {
           
            var ListDrugs = new List<Drug>
            {
                new Drug() {Description="ACARBOSA ", Existence=15},
                new Drug() {Description="ACECLOFENACO", Existence=15},
                new Drug() {Description="ACEMETACINAACENOCUMAROL", Existence=15},
                new Drug() {Description="ACICLOVIR", Existence=15},
                new Drug() {Description="AMBROXOL", Existence=15},
                new Drug() {Description="AMISULPRIDA", Existence=15},
                new Drug() {Description="ANASTROZOL", Existence=15},
                new Drug() {Description="BEZAFIBRATO", Existence=15},
                new Drug() {Description="BICALUTAMIDA", Existence=15},
                new Drug() {Description="BIFONAZOL", Existence=15},
                new Drug() {Description="BIMATOPROST", Existence=15},
                new Drug() {Description="BISACODILO Tableta ", Existence=15},
                new Drug() {Description="BROMAZEPAM", Existence=15},
                new Drug() {Description="BROMURO DE IPRATROPIO ", Existence=15},
                new Drug() {Description="BUDESONIDA", Existence=15},
                new Drug() {Description="CABERGOLINA", Existence=15},
                new Drug() {Description="CAFEÍNA / IBUPROFENO", Existence=15},
                new Drug() {Description="CAFEÍNA / PARACETAMOL", Existence=15},
                new Drug() {Description="CALCIPOTRIOL", Existence=15},
                new Drug() {Description="CAPTOPRIL", Existence=15},
                new Drug() {Description="CARBAMAZEPINA", Existence=15},
                new Drug() {Description="CEFALEXINA", Existence=15},
                new Drug() {Description="CEFPROZIL", Existence=15},
                new Drug() {Description="CEFTRIAXONA", Existence=15},
                new Drug() {Description="CICLOSPORINA", Existence=15},
                new Drug() {Description="DAPOXETINA", Existence=15},
                new Drug() {Description="DEGARELIX", Existence=15},
                new Drug() {Description="DESFLURANO", Existence=15},
                new Drug() {Description="DEXLANSOPRAZOL", Existence=15},
                new Drug() {Description="DIACEREINA", Existence=15},
                new Drug() {Description="DICLOFENACO", Existence=15},
                new Drug() {Description="DIMENHIDRINATO", Existence=15},
                new Drug() {Description="DOXOFILINA", Existence=15},
                new Drug() {Description="EBASTINA", Existence=15},
                new Drug() {Description="EMTRICITABINA", Existence=15},
                new Drug() {Description="ENFUVIRTIDA", Existence=15},
                new Drug() {Description="EPLERENONA", Existence=15},
                new Drug() {Description="ESOMEPRAZOL", Existence=15},
                new Drug() {Description="ESTAZOLAM", Existence=15},
                new Drug() {Description="ESTRIOL", Existence=15},
                new Drug() {Description="ETAMSILATO", Existence=15},
                new Drug() {Description="EVEROLIMUS", Existence=15},
                new Drug() {Description="FAMOTIDINA", Existence=15},
                new Drug() {Description="FENILEFRINA", Existence=15},
                new Drug() {Description="FENITOÍNA", Existence=15},
                new Drug() {Description="FENOFIBRATO", Existence=15},
                new Drug() {Description="FINASTERIDA", Existence=15},
                new Drug() {Description="FLUCONAZOL", Existence=15},
                new Drug() {Description="FLUOCINONIDA", Existence=15},
                new Drug() {Description="FLUTRIMAZOL", Existence=15},
                new Drug() {Description="GABAPENTINA", Existence=15},
                new Drug() {Description="GLIMEPIRIDA", Existence=15},
                new Drug() {Description="GRANISETRÓN", Existence=15},
                new Drug() {Description="HEMEZOL", Existence=15},
                new Drug() {Description="HIDROCORTISONA", Existence=15},
                new Drug() {Description="HIDROXICARBAMIDA", Existence=15},
                new Drug() {Description="IBUPROFENO", Existence=15},
                new Drug() {Description="ISOTRETINOINA", Existence=15},
                new Drug() {Description="LACOSAMIDA", Existence=15},
                new Drug() {Description="LAPATINIB", Existence=15},
                new Drug() {Description="LEUPRORELINA", Existence=15},
                new Drug() {Description="LEVETIRACETAM", Existence=15},
                new Drug() {Description="LEVONORGESTREL", Existence=15},
                new Drug() {Description="LIDOCAINA / PRILOCAINA ", Existence=15},
                new Drug() {Description="LINEZOLID", Existence=15},
                new Drug() {Description="LORATADINA", Existence=15},
                new Drug() {Description="MELATONINA", Existence=15},
                new Drug() {Description="MIDAZOLAM", Existence=15},
                new Drug() {Description="NAPROXENO sódico", Existence=15},
                new Drug() {Description="NAPROXENO", Existence=15},
                new Drug() {Description="NIFURATEL", Existence=15},
                new Drug() {Description="NIMESULIDA", Existence=15},
                new Drug() {Description="NITAZOXANIDA", Existence=15},
                new Drug() {Description="OMEPRAZOL", Existence=15},
                new Drug() {Description="OXALIPLATINO", Existence=15},
                new Drug() {Description="PARACETAMOL", Existence=15},
                new Drug() {Description="PIDOTIMOD", Existence=15},
                new Drug() {Description="RIVAROXABÁN", Existence=15},
                new Drug() {Description="RIVASTIGMINA", Existence=15},
                new Drug() {Description="SALBUTAMOL", Existence=15},
                new Drug() {Description="SECNIDAZOL", Existence=15},
                new Drug() {Description="SIROLIMUS", Existence=15},
                new Drug() {Description="TACROLIMUS", Existence=15},
                new Drug() {Description="TADALAFIL", Existence=15},
                new Drug() {Description="TROXERUTINA", Existence=15},
                new Drug() {Description="VORINOSTAT", Existence=15},
                new Drug() {Description="ZAFIRLUKAST", Existence=15},
                new Drug() {Description="ZIDOVUDINA", Existence=15},
                new Drug() {Description="ZOFENOPRIL", Existence=15}

            };
            
            return ListDrugs;
            
        }
    }
}
