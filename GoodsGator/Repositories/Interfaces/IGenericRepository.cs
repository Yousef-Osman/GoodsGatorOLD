﻿using GoodsGator.Models.DbEntities;
using GoodsGator.Specifications;

namespace GoodsGator.Repositories.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync<G>(G id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetEntityWithSpecAsync(ISpecification<T> spec);
    Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec);
}
