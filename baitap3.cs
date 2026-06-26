using System;

class HocSinh
{
    // 1. Thuộc tính riêng tư (Private)
    private string _ten;
    private double _diemToan;
    private double _diemLy;
    private double _diemHoa;

    // 2. Property get/set với kiểm tra hợp lệ
    public string Ten
    {
        get { return _ten; }
        set { _ten = value; }
    }

    public double DiemToan
    {
        get { return _diemToan; }
        set
        {
            if (value < 0 || value > 10)
            {
                Console.WriteLine("Điểm Toán không hợp lệ! Tự động gán = 0.");
                _diemToan = 0;
            }
            else
            {
                _diemToan = value;
            }
        }
    }

    public double DiemLy
    {
        get { return _diemLy; }
        set
        {
            if (value < 0 || value > 10)
            {
                Console.WriteLine("Điểm Lý không hợp lệ! Tự động gán = 0.");
                _diemLy = 0;
            }
            else
            {
                _diemLy = value;
            }
        }
    }

    public double DiemHoa
    {
        get { return _diemHoa; }
        set
        {
            if (value < 0 || value > 10)
            {
                Console.WriteLine("Điểm Hóa không hợp lệ! Tự động gán = 0.");
                _diemHoa = 0;
            }
            else
            {
                _diemHoa = value;
            }
        }
    }

    // 3. Constructor (khởi tạo giá trị mặc định)
    public HocSinh()
    {
        _ten     = "Chưa có tên";
        _diemToan = 0;
        _diemLy  = 0;
        _diemHoa = 0;
    }

    // 4. Phương thức nhập thông tin
    public void NhapThongTin()
    {
        Console.Write("Nhập tên học sinh: ");
        Ten = Console.ReadLine();

        Console.Write("Nhập điểm Toán: ");
        DiemToan = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm Lý: ");
        DiemLy = double.Parse(Console.ReadLine());

        Console.Write("Nhập điểm Hóa: ");
        DiemHoa = double.Parse(Console.ReadLine());
    }

    // 5. Phương thức tính điểm trung bình
    public double TinhDiemTrungBinh()
    {
        return (_diemToan + _diemLy + _diemHoa) / 3.0;
    }

    // 6. Phương thức hiển thị
    public void HienThi()
    {
        double dtb = TinhDiemTrungBinh();
        string xepLoai;

        if (dtb >= 8.0)
            xepLoai = "Giỏi";
        else if (dtb >= 6.5)
            xepLoai = "Khá";
        else if (dtb >= 5.0)
            xepLoai = "Trung bình";
        else
            xepLoai = "Yếu";

        Console.WriteLine("==================================");
        Console.WriteLine("Tên học sinh : " + Ten);
        Console.WriteLine("Điểm Toán    : " + DiemToan);
        Console.WriteLine("Điểm Lý      : " + DiemLy);
        Console.WriteLine("Điểm Hóa     : " + DiemHoa);
        Console.WriteLine("Điểm TB      : " + dtb.ToString("F2"));
        Console.WriteLine("Xếp loại     : " + xepLoai);
        Console.WriteLine("==================================");
    }
}

class baitap4
{
    static void Main(string[] args)
    {
        HocSinh hs = new HocSinh();
        hs.NhapThongTin();
        hs.HienThi();
    }
}