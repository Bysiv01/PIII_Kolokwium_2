using System;

namespace PIII_Kolokwium_2
{
    interface IChronometr<T>
    {
        bool Equals(T obj);
        public string PodajCzas()
        {
            return "tekst";
        }

    }
    class Zegarek : IChronometr<Zegarek>
    {
        public bool Equals(Zegarek zegarek)
        {
            return true;
        }

    }
    class Piec
    {
        public bool CzyWlaczony;
    }
    class Termostat : Piec
    {
        public int TempMin;
        public int TempMax;

        public event EventHandler ZaZimno;
        public event EventHandler ZaCieplo;

        public void Sprawdz(int temperatura)
        {
            if (temperatura < TempMin)
            {
                EventHandler handler = ZaZimno;
            }
            else if (temperatura > TempMax)
            {
                EventHandler handler = ZaCieplo;
            }
        }
    }
    class Dom : Termostat
    {
        public int temperatura;
        public void Cykl()
        {
            if (CzyWlaczony == true)
            {
                temperatura++;
            }
            else if (CzyWlaczony == false)
            {
                temperatura--;
            }

            Sprawdz(temperatura);
        }

        public EventHandler ZaZimno;

        public EventHandler ZaCieplo;

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
