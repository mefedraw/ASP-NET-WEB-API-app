﻿namespace WebApplication1.Contracts
{
    public record GetAllCardsResponse(
        Guid Id,
        string Tg_id,
        short Type,
        int Count);   
}