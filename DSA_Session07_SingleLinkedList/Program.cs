using System;
namespace DSA_Session07_SingleLinkedList
//Author: Vũ Nguyễn Đức Trí - 2500115657

{
    //1. ĐỊNH NGHĨA CLASS NODE: MỘT MẮT XÍCH TRONG DANH SÁCH
    public class Node
    {
        public int Data;    //Dữ liệu của mắt xích
        public Node Next;   //"Sợi dây" trỏ đến mắt xích tiếp theo

        //Constructor: Khởi tạo giá trị khi tạo Node mới
        public Node(int data)
        {
            Data = data;
            Next = null;    //Mặc định sinh ra chưa nối với ai cả
        }
    }
    //2. ĐỊNH NGHĨA CLASS SINGLE LINKED LIST: DANH SÁCH LIÊN KẾT ĐƠN
    public class SingleLinkedList
    {
        private Node head;  //"Cái đầu" của danh sách, nơi bắt đầu
                            //Constructor: Khởi tạo danh sách rỗng
        public SingleLinkedList()
        {
            head = null;    //Ban đầu chưa có danh sách nào
        }
        //3. PHƯƠNG THỨC THÊM MẮT XÍCH VÀO CUỐI DANH SÁCH
        public void AddLast(int data)
        {
            Node newNode = new Node(data);  //Tạo mắt xích mới với dữ liệu
            if (head == null)   //0(1)
            {
                head = newNode;    //Nếu danh sách rỗng, newNode trở thành head
                return;
            }
            Node current = head;    //Bắt đầu từ head
            while (current.Next != null)    //0(n)
            {
                current = current.Next;     //Đi tiếp đến mắt xích cuối cùng
            }
            current.Next = newNode;     //Nối mắt xích cuối cùng vói newNode
        }
        //4. PHƯƠNG THỨC IN RA DANH SÁCH
        public void PrintList()
        {
            Node current = head;    //Bắt đầu head
            while (current != null)     //0(n)
            {
                Console.Write(current.Data + " -> ");   //In dữ liệu của mắt xích
                current = current.Next;     //Đi tiếp đến mắt xích tiếp theo
            }
            Console.WriteLine("null");  //Kết thúc danh sách
        }
    }
    //5. CHƯƠNG TRÌNH CHÍNH: TEST DANH SÁCH LIÊN KẾT ĐƠN
    class Program
    {
        static void Main(string[] args)
        {
            //tạo 1 instance của SingleLinkedList để quản lí danh sách
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Chao mung den voi danh sach lien ket don !");
            //tạo menu để người dùng chọn thao tác
            while (true)
            {
                Console.WriteLine("Vui long chon thao tac:");
                Console.WriteLine("1. Tham mat xich vao cuoi danh sach");
                Console.WriteLine("2. In ra danh sach");
                Console.WriteLine("3. Xoa danh sach");
                Console.WriteLine("4. Thoat");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Thêm mắt xích vào cuối danh sách
                        Console.Write("Nhap du lieu cho mat xich moi: ");
                        int data = int.Parse(Console.ReadLine());
                        list.AddLast(data);
                        break;
                    case "2": //In ra danh sách hiện tại
                        list.PrintList();
                        break;
                    case "3": //Xóa danh sách bằng cách tạo 1 instance mới,
                    //"đánh rơi" instance cũ
                        list = new SingleLinkedList();
                        Console.WriteLine("Danh sach da duoc xoa.");
                        break;
                    case "4": //Thoát khỏi chương trính
                        return; //Kết thúc hàm main, thoát chương trình
                    default: //Nếu người dùng nhập lựa chọn không hợp lệ
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}
