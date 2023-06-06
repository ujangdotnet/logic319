using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic06
{
    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;
        public string platno;

        public void Utama()
        {
            Console.WriteLine($"Nama\t: {nama}");
            Console.WriteLine($"PlatNo\t: {platno}");
            Console.WriteLine($"Bensin\t: {bensin}");
            Console.WriteLine($"Kecepatan\t: {kecepatan}");
            Console.WriteLine($"Posisi\t: {posisi}");
        }

        public void Percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }
        public void Maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void IsiBensin(double bensin)
        {
            this.bensin += bensin;
        }
    }
}
