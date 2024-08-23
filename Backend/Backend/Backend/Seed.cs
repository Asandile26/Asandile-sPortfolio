using Backend.Data;
using Backend.Models;

namespace Backend
{
    public class Seed(DataContext context)
    {
        private readonly DataContext dataContext = context;

        public void SeedDataContext()
        {
            if (!dataContext.Testimonials.Any() && !dataContext.Resume.Any() && !dataContext.Projects.Any())
            {
                var resume = new List<Resume>
                {
                    new Resume
                    {
                        Year = 2012,
                        NameOfInstitution = "J.S Skenjana S.S.S",
                        Description = "Matric",
                        StartDate = new DateTime(2012, 1, 25),
                        EndDate = new DateTime(2014, 12, 15),
                    },
                    new Resume
                    {
                        Year = 2015,
                        NameOfInstitution = "University of the Western Cape",
                        Description = "Bachelor of commerce",
                        StartDate = new DateTime(2015, 1, 25),
                        EndDate = new DateTime(2020, 11, 30),
                    },
                    new Resume
                    {
                        Year = 2022,
                        NameOfInstitution = "Life Choices Academy",
                        Description = "Web Development certifcate",
                        StartDate = new DateTime(2022, 09, 26),
                        EndDate = new DateTime(2023, 03, 31),
                    },
                    new Resume
                       {
                        Year = 2023,
                        NameOfInstitution = "Life Choices Academy Studio",
                        Description = "Intern",
                        StartDate = new DateTime(2023, 04, 17),
                        EndDate = new DateTime(2023, 05, 31),
                    },
                    new Resume
                    {
                        Year = 2023,
                        NameOfInstitution = "Payment24",
                        Description = "Internship (Software developer)",
                        StartDate = new DateTime(2023, 06, 1),
                        EndDate = new DateTime(2023, 08, 31),
                    },
                    new Resume
                    {
                        Year = 2024,
                        NameOfInstitution = "1Nebula",
                        Description = "Internship (Software developer)",
                        StartDate = new DateTime(2024, 01, 09),
                        EndDate = new DateTime(2024, 08, 30),
                    },
                };

                var testimonials = new List<Testimonials>
                {
                    new Testimonials
                    {
                        Name = "Athenkosi Freddie",
                        Testimonial = "Asandile is a super nice person who is open & wise. He is always open to helping others and He is not afraid to express himself. He is a visionary and futurist, He is always open to learning about the people around annd also an amzing conversationalist. I am glad to know him as a person",
                        Image = "https://i.postimg.cc/MGkfjTqR/Athii.png"
                    },
                   new Testimonials
                    {
                        Name = "Umayr Nordien",
                        Testimonial = "I know I can count on Asandile to work with me on both large and small projects. He is loyal to his ethical conduct and, based on my professional experience, does not deviate from these values. He is easy-going, and caring, with a strong mentality and always ready to help others",
                        Image = "https://i.postimg.cc/k5MgYkXG/Umayr.jpg"
                    },
                    new Testimonials
                    {
                        Name = "Reece Simon",
                        Testimonial = "For the short time I know Asandile he has been significantly amliorative towards assisting me. Definately is going to be successful going forward",
                        Image = "https://i.postimg.cc/Cxg1kR3j/Reece.jpg"
                    },
                    new Testimonials
                    {
                        Name = "Joel Mukanya",
                        Testimonial = "Asandile is a very creative and well-behaved student. He does enjoy working with his classmates and works well on his project. He has gained knowledge of web development, including Bootstrap 5. I will be very delighted to see him get hired.",
                        Image = "https://i.postimg.cc/s2fZsLcG/Joel.png"
                    },
                    new Testimonials
                    {
                        Name = "Meezan Davids",
                        Testimonial = "Asandile seems like a very nice guy to be in the presence. He is very good at sport and has a lot of takes on a lot of topics. Asandile looks like a respectable guy and will always be at help when in the need.",
                        Image = "https://i.postimg.cc/x8fJvcJx/Meez.jpg"
                    },
                    new Testimonials
                    {
                        Name = "Gift Mahlangu",
                        Testimonial = "Asandile is a smart and reliable person, who is always on time in class and gives 100% effort to his work and projects. He is a great team player and is always available to assist his peers, and also works well on his own. He would be a great asset to any company.",
                        Image = "https://i.postimg.cc/bwV3X10P/Gift.png"
                    }
                };
                var projects = new List<Project>
                {
                    new Project
                    {
                        Name = "'Portfolio (HTML & CSS)'",
                        GitHub = "https://github.com/Asandile26/portfolio2.git",
                        Netlify = "https://portfolioasandilelangeni.netlify.app",
                        Image = "https://i.postimg.cc/kGtd8nn6/first-Porty.png",
                    },
                    new Project
                    {
                        Name = "E-Commerce",
                        GitHub = "https://github.com/Asandile26/Ecommerce.git",
                        Netlify = "https://asandilelangeniecommerce.netlify.app",
                        Image = "https://i.postimg.cc/rzX2Nvmh/Old-Ecommerc.png",
                    },
                    new Project
                    {
                        Name = "E-Commerce (Javascript)",
                        GitHub = "https://github.com/Asandile26/Project-E-commerce.git",
                        Netlify = "https://asandilelangeni-ecommerce.netlify.app",
                        Image = "https://i.postimg.cc/SKDqbTTs/E-commerce.png",
                    },
                     new Project
                     {
                        Name = "CapStone",
                        GitHub = "https://github.com/Asandile26/capstone_final.git",
                        Netlify = "https://capstone-asandile.firebaseapp.com/",
                        Image = "https://i.postimg.cc/DfgrZsSJ/Capstone.png",
                     },
                new Project
                {
                     Name = "Calculator",
                     GitHub = "https://github.com/Asandile26/calculator.git",
                     Netlify = "https://asandilelangenicalculator.netlify.app",
                     Image = "https://i.postimg.cc/9QyFKBHR/Calculator.png",
                },
                new Project
                    {
                     Name = "Vue-Portfolio",
                     GitHub = "https://github.com/Asandile26/Vue-Portfolio.git",
                     Netlify = "https://portfolio-asandilelangeni.netlify.app",
                     Image = "https://i.postimg.cc/SQwnPRYP/Vue-portfolio.png",
                    },
                };


                var users = new List<User>
                {
                    new User
                    {
                        Name = "Asandile",
                        LastName = "Doe",
                        Email = "john.doe@example.com",
                        Password = "password123",
                    },

                };

                dataContext.Resume.AddRange(resume);
                dataContext.Testimonials.AddRange(testimonials);
                dataContext.Projects.AddRange(projects);
                dataContext.Users.AddRange(users);
                dataContext.SaveChanges();
            }
        }
    }
}
