namespace ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int size;
            //int queries;
            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);

            //do
            //{
            //    Console.WriteLine("Enter Size Of Number Of Queries");
            //    isparsed = int.TryParse(Console.ReadLine(), out queries);

            //} while (!isparsed || queries! <= 0);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter Elements Of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i+1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out nums[i]);

            //    } while (!isparsed);
            //}

            //int[] Queries = new int[queries];
            //Console.WriteLine("Enter Elements Of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter query no .{i+1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out Queries[i]);

            //    } while (!isparsed);
            //}

            //Console.Clear();

            //for (int i = 0; i < Queries.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[j] > Queries[i]) count++;
            //    }
            //    Console.WriteLine($"number of elements greater than {Queries[i]} is {count}");
            //}
            #endregion

            #region Q2
            //int size;
            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);


            //int[] nums = new int[size];
            //Console.WriteLine("Enter Elements Of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i + 1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out nums[i]);

            //    } while (!isparsed);
            //}
            //Console.Clear();

            //bool plaindorme = true;
            //for (int i = 0; i < nums.Length / 2; i++)
            //{
            //    if (nums[i] != nums[nums.Length - i - 1])
            //    {
            //        plaindorme = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(plaindorme?"Array is plaindorme": "Array is not plaindorme");
            #endregion

            #region Q3
            //int size;
            //int element;

            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Queue");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);

            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine("Enter Elements Of Queue");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i + 1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out element);

            //    } while (!isparsed);

            //    queue.Enqueue(element);
            //}
            //Console.Clear();

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("----------");

            //Helper.ReverseQueue(queue);

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q4
            //string str;

            //do
            //{
            //    Console.WriteLine("Enter Expression");
            //    str = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(str));

            //if (Helper.Balanced(str))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}
            #endregion

            #region Q5
            //int size;
            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter Elements Of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i + 1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out nums[i]);

            //    } while (!isparsed);
            //}
            //Console.Clear();

            //int[] uniqearray= Helper.RemoveDuplicates(nums);
            //foreach (int i in uniqearray)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q6
            //int size;
            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter Elements Of Array");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i + 1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out nums[i]);

            //    } while (!isparsed);
            //}
            //Console.Clear();

            //int[] evennums = Helper.RemoveOddNums(nums);
            //foreach (int i in evennums)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q7
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("apple");
            //queue.Enqueue(1.35);
            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            //int size;
            //int element;
            //int target;


            //bool isparsed;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Stack");
            //    isparsed = int.TryParse(Console.ReadLine(), out size);

            //} while (!isparsed || size! <= 0);


            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine("Enter Elements Of Stack");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element no .{i + 1}");
            //        isparsed = int.TryParse(Console.ReadLine(), out element);

            //    } while (!isparsed);

            //    stack.Push(element);
            //}

            //do
            //{
            //    Console.WriteLine($"Enter Target");
            //    isparsed = int.TryParse(Console.ReadLine(), out target);

            //} while (!isparsed);
            //Console.Clear();

            //Helper.Target(stack, target);


            #endregion


        }
    }
}
