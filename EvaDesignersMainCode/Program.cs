using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Person
{
    public string Email;
    public string password;
    public int code;
    public string name;

    public abstract void SetData(string email, string password, int code, string name);


}

class Manger : Person
{
    public override void SetData(string email, string password, int code, string name)
    {
        this.Email = email;
        this.password = password;

    }
}

class Employee : Person
{
    public override void SetData(string email, string password, int code, string name)
    {
        this.Email = email;
        this.password = password;
        this.code = code;
        this.name = name;
    }
}

class Machine
{
    public string namemachine;
    public string previous;
    public string validity;
    public string itemdescriptionl;
    public int quantity;
    public int code;
    public string Email;

    public void clean(int code, string namemachine, string previous, string validity, string Email)
    {
        this.namemachine = namemachine;
        this.previous = previous;
        this.validity = validity;
        this.code = code;
        this.Email = Email;
    }

    public void UnderClean(int code, string namemachine, string previous, string Email)
    {
        this.namemachine = namemachine;
        this.previous = previous;
        this.code = code;
        this.Email = Email;
    }
    public void waste(int code, string itemdescription, int quantity, string Email)
    {
        this.code = code;
        this.itemdescriptionl = itemdescription;
        this.quantity = quantity;
        this.Email = Email;
    }
}
class product
{
    public string Email;
    public string type;
    public string description;
    public string preapreationdate;
    public string VALidity;
    public string productname;
    public string datestarted;
    public void machineinprocess(string productname, string datestarted, string email)
    {
        this.productname = productname;
        this.datestarted = datestarted;
        this.Email = email;

    }
    public void nonproductitem(string type, string description, string preparetiondate, string VALidity, string email)
    {
        this.type = type;
        this.description = description;
        this.preapreationdate = preparetiondate;
        this.VALidity = VALidity;
        this.Email = email;
    }
}
class room
{
    public string Namemachine;
    public string Previous;
    public string Validity;
    public string Itemdescriptionl;
    public int Quantity;
    public int Code;
    public string Email;

    public void Clean(int Code, string Namemachine, string Previous, string Validity, string Email)
    {
        this.Code = Code;
        this.Namemachine = Namemachine;
        this.Previous = Previous;
        this.Validity = Validity;
        this.Email = Email;
    }
    public void Underclean(int Code, string Namemachine, string Previous, string Email)
    {
        this.Code = Code;
        this.Namemachine = Namemachine;
        this.Previous = Previous;
        this.Email = Email;
    }
    public void Waste(int Code, string Itemdescription, int Quantity, string Email)
    {
        this.Code = Code;
        this.Itemdescriptionl = Itemdescription;
        this.Quantity = Quantity;
        this.Email = Email;
    }
}


namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            //employee
            List<Employee> Emplist = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.SetData("ahmed@gmail.com", "123456", 0123, "ahmed");
            Emplist.Add(emp1);
            Employee emp2 = new Employee();
            emp2.SetData("mohamed@gmail.com", "789100", 123, "mohamed");
            Emplist.Add(emp2);

            //manger
            List<Manger> mangerlist = new List<Manger>();
            Manger man = new Manger();
            man.SetData("hazem@gmail.com", "567890", 1, "");
            mangerlist.Add(man);
            Manger man1 = new Manger();
            man1.SetData("hany@gmail.com", "012345", 2, "");
            mangerlist.Add(man1);
            List<Machine> clean = new List<Machine>();
            List<Machine> undercleaning = new List<Machine>();
            List<Machine> waste = new List<Machine>();
            List<room> cleanroom = new List<room>();
            List<room> Undercleaning1 = new List<room>();
            List<room> Waste1 = new List<room>();
            List<product> machineinPROCESS = new List<product>();
            List<product> nonproductITEM = new List<product>();
            while (true)
            {
                Console.WriteLine("login as");
                Console.WriteLine("1- Employess");
                Console.WriteLine("2- manger");


                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("please add email");
                String email = Console.ReadLine();
                Console.WriteLine("please add password");
                String password = Console.ReadLine();

                if (x == 1)
                {
                    Console.WriteLine("please add code");
                    int code = int.Parse(Console.ReadLine());
                    int login = 0;

                    foreach (var l in Emplist)
                    {
                        if (l.Email == email && l.password == password && l.code == code)
                        {
                            login = 1;
                        }
                    }

                    if (login == 1)
                    {
                        Console.WriteLine("1-machine");
                        Console.WriteLine("2-Room");
                        Console.WriteLine("3-Product");
                        Console.WriteLine("4-How to use app");
                        Console.WriteLine("5-log out");
                        Console.WriteLine("6-exit");
                        int p = int.Parse(Console.ReadLine());
                        switch (p)
                        {
                            case 1:
                                Console.WriteLine("scan QR code of machine");
                                Console.WriteLine("write QR code : ");
                                int machinecode = int.Parse(Console.ReadLine());

                                Console.WriteLine("choose option for machine");
                                Console.WriteLine("1-clean");
                                Console.WriteLine("2-under cleaning");
                                Console.WriteLine("3-waste");
                                int machine = int.Parse(Console.ReadLine());
                                switch (machine)
                                {
                                    case 1:
                                        Console.WriteLine("please enter machine name");
                                        string name = Console.ReadLine();
                                        Console.WriteLine("please enter  previous");
                                        string previous = Console.ReadLine();
                                        Console.WriteLine("please enter validity");
                                        string validity = Console.ReadLine();
                                        Machine cleanobject = new Machine();
                                        cleanobject.clean(machinecode, name, previous, validity, email);
                                        clean.Add(cleanobject);
                                        Console.WriteLine("you choose clean machine");
                                        break;

                                    case 2:
                                        Console.WriteLine("please enter machine name");
                                        string undercleanname = Console.ReadLine();
                                        Console.WriteLine("please enter  previous");
                                        string undercleanprevious = Console.ReadLine();
                                        Machine undercleanobject = new Machine();
                                        undercleanobject.UnderClean(machinecode, undercleanname, undercleanprevious, email);
                                        undercleaning.Add(undercleanobject);
                                        Console.WriteLine("you choose machine as under cleaning");
                                        break;

                                    case 3:

                                        Console.WriteLine("please enter  item description");
                                        string itemdes1 = Console.ReadLine();
                                        Console.WriteLine("please enter quantity");
                                        int quantity = int.Parse(Console.ReadLine());
                                        Machine wasteobject = new Machine();
                                        wasteobject.waste(machinecode, itemdes1, quantity, email);
                                        waste.Add(wasteobject);
                                        Console.WriteLine("you choose machine as waste");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("scan QR code of room");
                                Console.WriteLine("write QR code : ");
                                int CODE = int.Parse(Console.ReadLine());
                                Console.WriteLine("choose option for room");
                                Console.WriteLine("1-clean");
                                Console.WriteLine("2-under cleaning");
                                Console.WriteLine("3-waste");
                                int room = int.Parse(Console.ReadLine());
                                switch (room)
                                {
                                    case 1:
                                        Console.WriteLine("please enter room name");
                                        string NAME = Console.ReadLine();
                                        Console.WriteLine("please enter  previous product");
                                        string PREVIOUS = Console.ReadLine();
                                        Console.WriteLine("please enter validity");
                                        string VALIDITY = Console.ReadLine();
                                        room CLEAN = new room();
                                        CLEAN.Clean(CODE, NAME, PREVIOUS, VALIDITY, email);
                                        cleanroom.Add(CLEAN);
                                        Console.WriteLine("you choose clean room");
                                        break;
                                    case 2:
                                        Console.WriteLine("please enter room name");
                                        string undercleanNAME = Console.ReadLine();
                                        Console.WriteLine("please enter  previous product");
                                        string undercleanPREVIOUS = Console.ReadLine();
                                        room UNDERCLEAN = new room();
                                        UNDERCLEAN.Underclean(CODE, undercleanNAME, undercleanPREVIOUS, email);
                                        Undercleaning1.Add(UNDERCLEAN);
                                        Console.WriteLine("you achoose  room as under cleaning");
                                        break;
                                    case 3:
                                        Console.WriteLine("please enter  item description");
                                        string itemdes11 = Console.ReadLine();
                                        Console.WriteLine("please enter quantity");
                                        int quantity1 = int.Parse(Console.ReadLine());
                                        room WASTE = new room();
                                        WASTE.Waste(CODE, itemdes11, quantity1, email);
                                        Waste1.Add(WASTE);
                                        Console.WriteLine("you choose machine as waste");
                                        break;
                                }
                                break;

                            case 3:
                                Console.WriteLine("Choose product:");
                                Console.WriteLine("1. Molnuplravlr");
                                Console.WriteLine("2. Esomeprazole");
                                Console.WriteLine("3. Zanoglide");
                                Console.WriteLine("4. Donifoxate");
                                int product = int.Parse(Console.ReadLine());
                                Console.WriteLine("you choose product : " + product);
                                Console.WriteLine("please choose card :");
                                Console.WriteLine("1- machine in process");
                                Console.WriteLine("2- non-product item");
                                int PRoDuct = int.Parse(Console.ReadLine());
                                Console.WriteLine("you choose card : " + PRoDuct);
                                switch (PRoDuct)
                                {
                                    case 1:
                                        Console.WriteLine("please enter product name");
                                        string productName = Console.ReadLine();
                                        Console.WriteLine("please enter date started");
                                        string Datestarted = Console.ReadLine();
                                        product machineINprocess = new product();
                                        machineINprocess.machineinprocess(productName, Datestarted, email);
                                        machineinPROCESS.Add(machineINprocess);
                                        Console.WriteLine("you choose product as machine in process");
                                        break;
                                    case 2:
                                        Console.WriteLine("please enter type");
                                        string TYPE = Console.ReadLine();
                                        Console.WriteLine("please enter description");
                                        string DESCRIPTION = Console.ReadLine();
                                        Console.WriteLine("please enter preparition date");
                                        string PREPRATION = Console.ReadLine();
                                        Console.WriteLine("please enter validity");
                                        string VALidity = Console.ReadLine();
                                        product NONproduct = new product();
                                        NONproduct.nonproductitem(TYPE, DESCRIPTION, PREPRATION, VALidity, email);
                                        nonproductITEM.Add(NONproduct);
                                        Console.WriteLine("you choose product as Non-product itrm");

                                        break;
                                }

                                break;

                            case 4:
                                Console.WriteLine("How to use the app:");
                                Console.WriteLine("1. Choose an option: Machine, Room, or Product.");
                                Console.WriteLine("2. If you choose Machine or Room, scan the QR code with your phone.");
                                Console.WriteLine("3. Select the action you want to perform: Clean, Under maintenance, or Waste.");
                                Console.WriteLine("4. Press 'Send' to submit your data.");
                                Console.WriteLine("5. If you choose Product, select a product from the list provided.");
                                Console.WriteLine("6. Choose an action other than Product for the operation.");
                                Console.WriteLine("7. Press 'Send' to submit your data.");

                                break;
                            case 5:
                                Console.WriteLine("you logged out");

                                break;
                            case 6:
                                Console.WriteLine("you are exiting the application");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("you choose wrong number");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("you add wrong data");
                        continue;
                    }

                }

                else if (x == 2)
                {

                    int login = 0;
                    foreach (var l in mangerlist)
                    {
                        if (l.Email == email && l.password == password)
                        {
                            login = 1;
                        }
                    }
                    if (login == 1)
                    {
                        Console.WriteLine("1.Add Employee");
                        Console.WriteLine("2.code of employee");
                        Console.WriteLine("3- log out");
                        Console.WriteLine("4-Exit");
                        int s = int.Parse(Console.ReadLine());
                        if (s == 1)
                        {

                            Console.WriteLine("Enter employee name:");
                            string employeeName = Console.ReadLine();
                            Console.WriteLine("Enter employee email:");
                            string employeeEmail = Console.ReadLine();
                            Console.WriteLine("Enter employee code:");
                            int employeeCode = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter employee password:");
                            string employeePassword = Console.ReadLine();
                            Employee emp3 = new Employee();
                            emp3.SetData(employeeEmail, employeePassword, employeeCode, employeeName);
                            Emplist.Add(emp3);
                            Console.WriteLine("Employee added successfully!");

                        }
                        else if (s == 2)
                        {
                            Console.WriteLine("please enter employee email");
                            string employeeemail = Console.ReadLine();
                            foreach (var k in clean)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose clean machine and this machine code is " + k.code);
                                }
                                else
                                {
                                    Console.WriteLine("the employee doesnt do anything");
                                }
                            }

                            foreach (var k in undercleaning)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose underclean machine and this machine code is " + k.code);
                                }
                            }

                            foreach (var k in waste)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose waste machine and this machine code is " + k.code);
                                }
                            }

                            foreach (var k in cleanroom)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose clean Room and this room id is " + k.Code);
                                }
                            }

                            foreach (var k in Undercleaning1)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose undercleaning Room and this room id is " + k.Code);
                                }
                            }

                            foreach (var k in Waste1)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose waste Room and this room id is " + k.Code);
                                }
                            }
                            foreach (var k in machineinPROCESS)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose product" + k.productname + " as machine in process");
                                }
                            }
                            foreach (var k in nonproductITEM)
                            {
                                if (employeeemail == k.Email)
                                {
                                    Console.WriteLine("empolyee choose product" + k.productname + " as non-product item");
                                }
                            }
                        }
                        else if (s == 3)
                        {
                            Console.WriteLine("you logged out");

                        }
                        else if (s == 4)
                        {
                            Console.WriteLine("you are exiting the application");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("you choose wrong number");

                        }

                    }

                    else
                    {
                        Console.WriteLine("you add wrong data");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("you choose wong number");

                }
            }


        }
    }
}
