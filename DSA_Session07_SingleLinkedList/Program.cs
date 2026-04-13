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
        //8.1. Viết hàm đến và trả về tổng số lượng Node đang có trong danh sách
        public int CountNodes()
        {
            int count = 0;  //Biến đếm số lượng Node
            Node current = head;    //Bắt đầu từ head
            while (current != null) //Duyệt qua danh sách
            {
                count++;    //Tăng biến đếm khi gặp 1 Node
                current = current.Next; //Đi tiếp Node tiếp theo
            }
            return count;   //Trả về tổng số lượng Node
        }
        //8.2. Tìm xem 1 số target có tồn tại trong danh sách hay không
        //(Gợi ý: Trả về true hoặc false)
        public bool SearchNode(int target)
        {
            Node current = head;    //Bắt đầu từ head
            while(current != null)  //Duyệt qua danh sách
            {
                if (current.Data == target) //Nếu tìm thấy target
                {
                    return true;    //Trả về true
                }
                current = current.Next; //Đi tiếp đến Node tiếp theo
            }
            return false;   //Nếu không tìm thấy, trả về false
        }
        //8.3. Xóa phần tử ở đầu danh sách. (Gợi ý: Cực kì đơn giản,
        //chỉ cần cho Head = Head.Next;). Kiểm tra kỹ trường hợp danh sách rỗng
        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }
        //8.4.Xóa Node ĐẦU TIÊN có Data bằng với giá trị value
        public void DeleteByValue(int value)
        {
            if (head == null)   //Nếu danh sách rỗng, không có gì để xóa
            {
                return;
            }
            if (head.Data == value) //Nếu Node đầu tiên có Data bằng value
            {
                head = head.Next;   //Nếu Node đầu tiên bằng cách cập nhật head
                return;
            }
            Node current = head;    //Bắt đầu từ head
            while (current.Next != null)    //Duyệt qua danh sách
            {
                if (current.Next.Data == value) //Nếu tìm thấy Node tiếp theo có
                //Data bằng value
                {   
                    current.Next = current.Next.Next;   //Bỏ qua Node đó để xóa nó
                    return;
                }
                current = current.Next; //Đi tiếp đến Node tiếp theo
            }
        }
        //8.5.Đảo ngược toàn bộ Danh sách liên kết mà KHÔNG được sử dụng thêm mảng phụ
        public void ReverseList()
        {
            Node prev = null;   //Node trước đó, ban đầu là null
            Node current = head;    //Node hiện tại, bắt đầu từ head
            while (current != null) //Duyệt qua danh sách
            {
                Node next = current.Next;   //Lưu trữ Node tiếp theo
                current!.Next = prev;   //Đảo ngược liên kết của Node hiện tại
                prev = current; //Cập nhật prev thành Node hiện tại
                current = next; //Di chuyển đến Node tiếp theo
            }
            head = prev;    //Cập nhật head thành Node cuối cùng sau khi đảo ngược
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
                Console.WriteLine("4. Dao nguoc danh sach");
                Console.WriteLine("5. Dem so luong Node trong danh sach");
                Console.WriteLine("6. Tim kiem mot gia tri trong danh sach");
                Console.WriteLine("7. Xoa Node dau tien");
                Console.WriteLine("8. Xoa Node co gia tri cu the");
                Console.WriteLine("9. Thoat");

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
                    case "4": //Đảo ngược danh sách
                        list.ReverseList();
                        Console.WriteLine("Danh sach da duoc dao nguoc.");
                        list.PrintList();   //In ra danh sách sau khi đảo ngược
                        break;
                    case "5": //Đếm số lượng Node trong danh sách
                        int count = list.CountNodes();
                        Console.WriteLine($"So luong Node trong danh sach: {count}");
                        break;
                    case "6": //Tìm kiếm một giá trị trong danh sách
                        Console.Write("Nhap gia tri can tim: ");
                        int SearchData = int.Parse(Console.ReadLine());
                        bool foundNode = list.SearchNode(SearchData);
                        if (foundNode)
                            Console.WriteLine($"Gia tri {SearchData} duoc tim thay trong danh sach.");
                        else 
                            Console.WriteLine($"Gia tri {SearchData} khong tom tai trong danh sach.");
                        break;
                    case "7": //Xóa Node đầu tiên
                        list.DeleteFirst();
                        Console.WriteLine("Node dau tien da duoc xoa.");
                        break;
                    case "8": //Xóa Node có giá trị cụ thễ
                        Console.Write("Nhap gia tri can xoa: ");
                        int DeleteData = int.Parse(Console.ReadLine());
                        list.DeleteByValue(DeleteData);
                        Console.WriteLine($"Node co gia tri {DeleteData} da duoc xoa.");
                        break;
                    case "9": //Thoát khỏi chương trình
                        return; //Kết thúc hàm Main, thoát chương trình
                    default:    //Nếu người dùng đăng nhập lựa chọn không hợp lệ
                        Console.WriteLine("Lua chon khong hop le !");
                        break;
                }
            }
        }
    }
}
