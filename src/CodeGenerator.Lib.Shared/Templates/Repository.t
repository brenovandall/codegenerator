using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{Namespace}};

#region auto-generated code © Breno Van-Dall - Júnior Belem
public class {{EntityName}}Repository : Repository<{{EntityName}}>, I{{EntityName}}Repository
{
    public {{EntityName}}Repository({{Context}} context, DbSet<{{EntityName}}> dbSet) : base(context, dbSet)
    {
    }
}
#endregion