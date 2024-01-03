﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace CleanArchMvc.Infra.Ioc
{
    public static class DependencyInjectionJwt
    {
        public static IServiceCollection AddInfrastructureJwt(this IServiceCollection services,
            IConfiguration configuration)
        {
            //Informar o tipo de atenticação JWT - Bearer
            //Definir o modelo de desafio de autenticação
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            //Habilita a autenticação JWT usando o esquema e desafio definidos 
            //Validar o token
            .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     //Valores válidos
                     ValidIssuer = configuration["Jwt:Issuer"],
                     ValidAudience = configuration["Jwt:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecretKey"])),
                     ClockSkew = TimeSpan.Zero
                 };
             });

            return services;
        }
    }
}
