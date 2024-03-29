﻿using ApiModelo.Domain.Core.Interfaces.Repositorys;
using ApiModelo.Domain.Core.Interfaces.Services;
using ApiModelo.Domain.Entitys;

namespace ApiModelo.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto> , IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
