using Microsoft.EntityFrameworkCore;
using QRA.Repositories.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Migrations.Content
{
    public static class DbInitializer
    {
        public static void Initialize(QRAContext context)
        {
            context.Database.Migrate();
        }
    }
}
