using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AccountAppSerializationDeserialization
{
    internal class JsonAccountRepository : IAccountRepository
    {
        
        
            private readonly string _filePath;

            public JsonAccountRepository(string filePath)
            {
                _filePath = filePath;
            }

            public void Save(List<BankAccount> accounts)
            {
                string json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }

            public List<BankAccount> Load()
            {
                if (!File.Exists(_filePath))
                    return new List<BankAccount>();

                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<BankAccount>>(json) ?? new List<BankAccount>();
            }
        }
    }

