﻿using P055_BatuParduotuve.Database.Models;

namespace P055_DB_DataSeed.Services
{
    public interface IParduotuveRepository
    {
        List<Batas> GetBatai();
        void InsertPardavimasIrSumazintiKieki(int dydzioId, int kiekis);
    }
}