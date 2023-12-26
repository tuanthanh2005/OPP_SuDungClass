using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Diem
    {
        public double x;
        public double y;

        public void NhapDiem()
        {
            Console.WriteLine("Nhập x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập y: ");
            y = double.Parse(Console.ReadLine());
        }
        public double TinhToan(Diem V)
        {
            double kq;
            kq = Math.Sqrt(Math.Pow(V.x - x, 2) + Math.Pow(V.y - y, 2));
            return kq;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Diem A, B;
            A = new Diem();
            B = new Diem();
            Console.WriteLine("Nhập điểm A: ");
            A.NhapDiem();
            Console.WriteLine("Nhập Điểm B: ");
            B.NhapDiem();
            double kq = A.TinhToan(B);
            Console.WriteLine("Xuat Ket Qua : {0}", kq);
            Console.ReadKey();
        }

    }
}