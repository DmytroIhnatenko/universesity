using System;


namespace universesity.Models

{
    public class Student
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public string tok_studiow { get; set; }
        public string status { get; set; }
        public int rok { get; set; }
        public int semestr { get; set; }
        public string grupa_wyk { get; set; }
        public string grupa_lab { get; set; }
      
        public int nr_albumu { get; set; }
        public string kierunek { get; set; }
      
        public string pesel { get; set; }
      
        public bool plec { get; set; }
      
        public string narodowosc { get; set; }
        public string obywatelstwo { get; set; }
     

        public string ulica { get; set; }
        public string kod_pocztowy { get; set; }
        public string miejscowosc { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }


  

        public Student(int userID, string tok_studiow, string status, int rok, int semestr, int nr_albumu, string wydzial, string kierunek, string specjalnosc, string specjalizacja, string uzyskiwany_tytul, string semestr_naboru, DateTime data_rozpoczecia, DateTime data_zakonczenia, bool tok_indywidualny, string pesel, string miejsce_urodzenia, bool plec, string stan_cywilny, string narodowosc, string obywatelstwo, string nr_dowodu, string nr_wojskowy, string imie_matki, string imie_ojca, string ulica, string kod_pocztowy, string miejscowosc, string email, string telefon, string nr_matury, string rok_wydania, string rok_ukonczenia, string szkola, string rodzaj_matura, string tryb, string grupa_wyk, string grupa_lab, string grupa_ang)
        {
            this.userID = userID;
            this.tok_studiow = tok_studiow;
            this.status = status;
            this.rok = rok;
            this.semestr = semestr;
            this.nr_albumu = nr_albumu;
           
            this.kierunek = kierunek;
          
            this.pesel = pesel;
           
            this.plec = plec;
            
            this.narodowosc = narodowosc;
            this.obywatelstwo = obywatelstwo;
        
            this.ulica = ulica;
            this.kod_pocztowy = kod_pocztowy;
            this.miejscowosc = miejscowosc;
            this.email = email;
            this.telefon = telefon;
           
            this.grupa_wyk = grupa_wyk;
            this.grupa_lab = grupa_lab;
          
        }

        public Student()
        {
        }
    }
}
