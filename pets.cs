using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace LucyPets

{

    public abstract class Pet

    {

        private string pet_name;

        private string pet_description;

        private int pet_age;

        private int pet_timesFedToday;


        //get and set pet variables
        public string name

        {

            get

            {

                return pet_name;

            }

            set

            {

                pet_name = value;

            }

        }

        public string description

        {

            get

            {

                return pet_description;

            }

            set

            {

                pet_description = value;

            }

        }

        public int age

        {

            get

            {

                return pet_age;

            }

            set

            {

                pet_age = value;

            }

        }

        public int timesFedToday

        {

            get

            {

                return pet_timesFedToday;

            }

            set

            {

                pet_timesFedToday = value;

            }

        }







    }


    
    public class Dog : Pet

    {

        private int dog_happiness;

        private int dog_hunger;


        //get & set dog variables
        public int happiness
           
        {

            get

            {

                return dog_happiness;

            }

            set

            {

                dog_happiness = value;

            }

        }

        public int hunger

        {

            get

            {

                return dog_hunger;

            }

            set

            {

                dog_hunger = value;

            }

        }




        //construct dog with no parameters
        public Dog()

        {

            name = "aDog";

            description = "a simple dog";

            age = 0;

            timesFedToday = 0;

            happiness = 3;

            hunger = 0;

        }


        //constructor with parameters
        public Dog(string aName, string aDescription, int anAge)

        {

            name = aName;

            description = aDescription;

            age = anAge;

            timesFedToday = 0;

            happiness = 3;

            hunger = 0;

        }




        //get methods
        public int getHappiness()

        {

            return happiness;

        }



        public int getHunger()

        {

            return hunger;

        }


        //feed dog decrease hunger, increase happiness
        void feed()

        {

            hunger--;

            happiness++;

            Console.WriteLine("Sucessfully Fed!");

        }

        //walk dog method
        void walkies()

        {

            if (hunger >= 1)

            {

                hunger--;

                happiness++;
                Console.WriteLine("Sucessfully Walked!");

            }

            else

            {

                Console.WriteLine("Too Hungry to walk, feed me first");

            }



        }


        //dog output
        public void Output()

        {

            string task = "A";



            while (task != "E")

            {

                if (happiness >= 1)

                {

                    Console.WriteLine("{0} is happy, what do you want to do? W for walk F for feed E to exit", name);

                    task = Console.ReadLine();
                    task = task.ToUpper();


                    if (task == "W")

                    {

                        this.walkies();

                        Console.WriteLine("What next? W for walk F for feed E to exit");
                        task = Console.ReadLine();
                        task = task.ToUpper();
                    }

                    if (task == "F")

                    {

                        this.feed();

                        Console.WriteLine("What next? W for walk F for feed E to exit");

                        task = Console.ReadLine();
                        task = task.ToUpper();
                    }

                    else

                    {

                        Console.WriteLine("I don't know what you want to do, try again");

                        task = Console.ReadLine();
                        task = task.ToUpper();
                    }

                }

                else

                {

                    Console.WriteLine("{0} is sad, and unable to do anything :(");

                    task = "E";

                }

            }

        }

    }


    
    public class Cat : Pet

    {

        //create cat variables
        int cat_sleepy;

        int cat_hoursSlept;


        // get and set cat variables
        public int sleepy

        {

            get

            {

                return cat_sleepy;

            }

            set

            {

                cat_sleepy = value;

            }

        }

        public int hoursSlept

        {

            get

            {

                return cat_hoursSlept;

            }

            set

            {

                cat_hoursSlept = value;

            }

        }


        //constructor with parameters
        public Cat(string aName, string aDescription, int anAge)

        {

            name = aName;

            description = aDescription;

            age = anAge;

            timesFedToday = 0;

            sleepy = 10;

            hoursSlept = 0;

        }


        //constuctor with no parameters
        public Cat()

        {

            name = "ted";

            description = "fat cat";

            age = 40;

            timesFedToday = 0;

            sleepy = 10;

            hoursSlept = 0;

        }




        //sleep method
        public void sleep(int aNumber)

        {

            sleepy = sleepy - 2;

            hoursSlept = aNumber;
            Console.WriteLine("That worked!");

        }


        //hunt method
        public void hunt()

        {

            sleepy = sleepy + 1;
            Console.WriteLine("Sucessfully Hunted!");

        }


         // cat output
        public void Output()

        {

            string task = "A";



            while (task != "E")

            {

                if (sleepy <= 10)

                {

                    Console.WriteLine("{0} is sleepy, they are off to sleep, how many hours did they get?", name);

                    int timeSlept = Convert.ToInt32(Console.ReadLine());

                    sleep(timeSlept);

                }

                else

                {

                    Console.WriteLine("{0} is off hunting", name);

                }

                Console.WriteLine("Do you want to exit yet (E)?");

                task = Console.ReadLine();
                task = task.ToUpper();
            }



        }

    }




//main program
    class Program

    {

        static void Main(string[] args)

        {

            string name = "Max";

            int age = 1;

            string description = "Not sure really";





            //user input

            try

            {

                Console.WriteLine("What is your pets' name?");

                name = Console.ReadLine();

                Console.WriteLine("How old are they?");

                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How would you describe them?");

                description = Console.ReadLine();

            }

            catch

            {

                Console.WriteLine("Sorry I don't know what you entered,  I will fill this out for you :)");





            }



            Console.WriteLine("Are they a cat (1) or a dog (2)?");

            string answer = Console.ReadLine();

            //create dog if 2 and do dog output

            if (answer == "2")

            {

                Dog aDog = new Dog(name, description, age);

                aDog.Output();

            }

            else

            {
                
            //create cat if 1 and do cat output

                if (answer == "1")

                {

                    Cat aCat = new Cat(name, description, age);

                    aCat.Output();

                }

                else Console.WriteLine("Whatever you entered doesn't count");

            }

        }

    }

}
