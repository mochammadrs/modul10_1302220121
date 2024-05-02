using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaControllers : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Mochammad Rizky Septian", "1302220121", new List<string> {"Kontruksi Perangkat Lunak"}, 2024),
            new Mahasiswa("Muhammad Rafif AryaSatya Purnomo ", "1302220003", new List<string> {"Kontruksi Perangkat Lunak"}, 2024),
            new Mahasiswa ("Muhammad Ghaziveda Belvanaufal", "1302220011", new List<string> {"Kontruksi Perangkat Lunak"}, 2024)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GetMahasiswas()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa GetMahasiswa(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void PostMahasiswa(Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpPut("{id}")]
        public void PutMahasiswa(int id, Mahasiswa mahasiswa)
        {
            dataMahasiswa[id] = mahasiswa;
        }

        [HttpDelete("{id}")]
        public void DeleteMahasiswa(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
