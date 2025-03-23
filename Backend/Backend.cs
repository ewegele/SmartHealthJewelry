
using BackendCS;

public class Backend
{
    private static Backend _Instance;
    private Profile[] _profiles;
    private int _Index = 0;

    private Backend()

    {

        // Initalisierung von Profilen
        _profiles = new Profile[1];
        _profiles[0] = new Profile();
    }

    public static Backend Instance()
    {
        if (_Instance == null)
        {
            _Instance = new Backend();

        }

        return _Instance;
    }


    public Profile GetProfile()
    {
        return _profiles[_Index];
    }
}