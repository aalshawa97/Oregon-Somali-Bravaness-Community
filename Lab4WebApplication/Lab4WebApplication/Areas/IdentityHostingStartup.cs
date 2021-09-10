using Lab4WebApplication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace Lab4WebApplication.Areas
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) =>
            {
                /*
                services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(
                    )
                
                
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString
                );
               
            });

            
                
                        services.AddDbContext<AuthDbContext>(options =>
                            options.UsqSqlServer(
                                )
                    }
                });

            }
                
              
            };
            */
            });
         }
    }
}