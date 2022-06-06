using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MuonTraSach
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("MaDG")] public virtual DocGia DocGia { get; set; }
        public long MaDG { get; set; }

        [ForeignKey("MaThuThu")] public virtual ThuThu ThuThu { get; set; }
        public long MaThuThu { get; set; }

        public ICollection<Sach> Sach { get; set; }

        [DataType(DataType.Date)] public DateTime? NgayMuon { get; set; }

        [DataType(DataType.Date)] public DateTime? NgayHenTra { get; set; }

        [DataType(DataType.Date)] public DateTime? NgayTra { get; set; }
    }
 
}
