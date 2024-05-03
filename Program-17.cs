class Store<T>
{
    public T[] Add_elem_Arr(T[] arr, T element)
    {
        T[] temp = new T[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }
        temp[temp.Length - 1] = element;
        return temp;
    }
    public T[] Delete_elem_Arr(T[] arr, T element)
    {
        T[] temp = new T[arr.Length - 1];

        for (int i = 0, k = 0; i < arr.Length; i++)
        {
            if (Convert.ToString(arr[i]) != Convert.ToString(element))
            {
                temp[k] = arr[i];
                k++;
            }
        }
        return temp;
    }
    public void Get_Elem_Index_Arr(T[] arr, int index) => Console.WriteLine($"{index} элемент массива - это {arr[index - 1]}");
    public void Get_Length_Arr(T[] arr) => Console.WriteLine($"Длина массива: {arr.Length}");
}

class PasswordsStore<T> : Store<T>
{
    public string[] Passwords = Array.Empty<string>();

    public string[] AddNewPassword(PasswordsStore <string> passwords, string password) => passwords.Passwords = passwords.Add_elem_Arr(passwords.Passwords, password);
}
class LoginsStore<T> : Store<T>
{
    public string[] Logins = Array.Empty<string>();

    public string[] AddNewLogin(LoginsStore <string> logins, string login) => logins.Logins = logins.Add_elem_Arr(logins.Logins, login);
}

internal class Program
{
    private static void Main(string[] args)
    {
        PasswordsStore<string> passwordStore = new();
        LoginsStore<string> loginStore = new();

        Console.WriteLine("Введите логин: ");
        string login = Console.ReadLine();
        loginStore.AddNewLogin(loginStore, login);

        Console.WriteLine("Введите пароль: ");
        string password = Console.ReadLine();
        passwordStore.AddNewPassword(passwordStore, password);
    }
}