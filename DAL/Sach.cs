using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Sach
    {
        [Key]
        public long MaSach { get; set; }

        public string TenSach { get; set; }

        public string TenTacGia { get; set; }

        public string NhaXuatBan { get; set; }

        public int NamXuatBan { get; set; }

        public int SoLuong { get; set; }

        public ICollection<MuonTraSach> MuonTraSach { get; set; }

        [ForeignKey("MaSach")] public virtual LoaiSach LoaiSach { get; set; }
        public long MaLoaiSach { get; set; }
    }
}
