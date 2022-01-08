﻿using Models;

namespace BL;
public interface IBL
{
    void GetAllPokemonCards();
    bool CheckUsernameExists(string s);
    bool Login(string u, string p);
    void AddNewUser(Customer c);
}