using Newtonsoft.Json;
using AutoMapper;
using System;

namespace Progrm
{
    class Program
    {
        public static void Main()
        {
            string json = GetHello();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            var mapper = config.CreateMapper();

            var user = new User { Name = "Tom", Age = 23 };
            var userDto = mapper.Map<UserDto>(user);

            System.Console.WriteLine(json + " " + userDto.Name + " " + userDto.Age);
        }

        public static string GetHello()
        {
            string json = JsonConvert.SerializeObject(new int[] { 1, 2, 3, 4, 5 });
            return json;
        }

        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class UserDto
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}