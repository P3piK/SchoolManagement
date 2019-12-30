using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SchoolManagement.Application;
using SchoolManagement.Application.Courses.Commands.CreateCourse;
using SchoolManagement.Application.Courses.Commands.UpdateCourse;
using SchoolManagement.Application.Courses.Queries.GetCourse;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Application.Users.Commands.CreateUser;
using SchoolManagement.Application.Users.Commands.UpdateUser;
using SchoolManagement.Application.Users.Queries.GetUser;
using SchoolManagement.Domain.Entities;
using SchoolManagement.Persistance;
using SchoolManagement.Persistance.Data;

namespace SchoolManagement.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContextPool<SmContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SchoolManagementDb"));
            });

            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<User, GetUserDto>().ConvertUsing<GetUserConverter>();
                cfg.CreateMap<CreateUserDto, User>().ConvertUsing<Application.Users.Commands.CreateUser.UserConverter>();
                cfg.CreateMap<UpdateUserDto, User>().ConvertUsing<Application.Users.Commands.UpdateUser.UserConverter>();
                cfg.CreateMap<Course, GetCourseDto>().ConvertUsing<GetCourseConverter>();
                cfg.CreateMap<CreateCourseDto, Course>().ConvertUsing<Application.Courses.Commands.CreateCourse.CourseConverter>();
                cfg.CreateMap<UpdateCourseDto, Course>().ConvertUsing<Application.Courses.Commands.UpdateCourse.CourseConverter>();
            }, typeof(ISqlBaseData<>));
            

            services.AddScoped<IUserData, UserData>();
            services.AddScoped<IGetUserQuery, GetUserQuery>();
            services.AddScoped<ICreateUserCommand, CreateUserCommand>();
            services.AddScoped<IUpdateUserCommand, UpdateUserCommand>();
            services.AddScoped<ICourseData, CourseData>();
            services.AddScoped<IGetCourseQuery, GetCourseQuery>();
            services.AddScoped<ICreateCourseCommand, CreateCourseCommand>();
            services.AddScoped<IUpdateCourseCommand, UpdateCourseCommand>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
