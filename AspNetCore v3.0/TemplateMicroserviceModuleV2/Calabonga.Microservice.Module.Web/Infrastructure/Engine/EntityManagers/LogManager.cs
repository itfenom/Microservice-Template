﻿using AutoMapper;
using Calabonga.EntityFrameworkCore.UOW.Framework.Factories;
using Calabonga.EntityFrameworkCore.UOW.Framework.Managers;
using $ext_projectname$.Entities;
using $safeprojectname$.Infrastructure.ViewModels.LogViewModels;
using Calabonga.Microservices.Core.Validators;

namespace $safeprojectname$.Infrastructure.Engine.EntityManagers
{
    /// <summary>
    /// Entity manager for <see cref="Log"/>
    /// </summary>
    public class LogManager: EntityManager<LogViewModel, Log, LogCreateViewModel, LogUpdateViewModel>
    {
        /// <inheritdoc />
        public LogManager(IMapper mapper, IViewModelFactory<LogCreateViewModel, LogUpdateViewModel> viewModelFactory, IEntityValidator<Log> validator)
            : base(mapper, viewModelFactory, validator)
        {
        }
    }
}
