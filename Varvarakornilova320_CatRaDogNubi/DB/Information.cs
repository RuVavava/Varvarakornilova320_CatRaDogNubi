//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Varvarakornilova320_CatRaDogNubi.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Information
    {
        public int ID_info { get; set; }
        public Nullable<int> ID_pet { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Pet Pet { get; set; }
    }
}
