//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatusControl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hardware
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hardware()
        {
            this.Hardware_Port = new HashSet<Hardware_Port>();
            this.Request = new HashSet<Request>();
        }
    
        public int Hardware_ID { get; set; }
        public string Hardware_Name { get; set; }
        public int Hardware_Type { get; set; }
        public string Hardware_Series { get; set; }
        public string MAC { get; set; }
        public string IP { get; set; }
        public System.DateTime Installment_Date { get; set; }
        public int Installment_Location { get; set; }
    
        public virtual Connection_Point Connection_Point { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hardware_Port> Hardware_Port { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual Hardware_Type Hardware_Type1 { get; set; }
    }
}
