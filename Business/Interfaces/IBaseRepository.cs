﻿namespace Business.Interfaces;

public interface IBaseRepository<TEntity>
{
    List<TEntity>? Deserialize(string json);
    List<TEntity>? GetFromFile();
    bool SaveToFile(List<TEntity> list);
    string Serialize(List<TEntity> list);
}