﻿using System;
using System.Collections.Generic;

namespace BookingBackend.Models;

public partial class Taikhoan
{
    public long MaTaiKhoan { get; set; }

    public int VaiTro { get; set; }

    public string TenTaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public virtual ICollection<Khachhang> Khachhangs { get; set; } = new List<Khachhang>();
}
