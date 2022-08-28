using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public interface IPerson
    {
        void Interact(IHobby hobis); //Pvz jei buna paduodamas filmas i ekrana turetu isvesti “<UserName> will now watch a<MovieName> which is a<Genre> movie.
        string GetFavoriteHobbyType(IHobby hobis); //Turetu gauti hobio tipa (pvz Movie). Atspausdinti apie tai informacija I ekrana ir grazinti atgal hobio pavadinima
        string GetFavoriteHobby(List<IHobby> MegstamiDalykai); //-> Turetu grazinti megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacija
        List<IHobby> GetFavoriteFromEachHobby(); //-> Turetu grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobio
        string GetFavoriteMusicGenre(); //-> Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose
        Dictionary<string, int> GetEachHobbyAvgRating();// -> Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkis
        void ShareHobbies(Person person2); //-> Pasidalina hobiais su paduotu zmogumi ir tie hobiai prisideda prie perduoto zmogaus hobiu
        void ShareOldMovies(Person person2); //-> Pasildaina filmais, kurie atsirado veliau nei 2010 metai
        List<IHobby> FindSimilarHobbies(Person person2); // -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais
        List<IHobby> FindSimilarHobbies(Person person2, string hobbyType); //-> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais ir yra tik tarp perduoto hobbyType pvz filmu
        List<string> FindMatchingGenres(Person person2, string hobbyType); //-> Randa sutampancius zanrus su paduoto zmogaus, kurie butu paduoto hobby tipo

    }
}
