using AutoMapper;

namespace Template.Domain.Helpers;

public static class Mapping
{
    public static T2 Map<T1, T2>(T1 from)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
        var map = new Mapper(config);
        var result = map.Map<T2>(from);
        return result;
    }

    public static List<T2> MapList<T1, T2>(List<T1> from)
    {
        if (from == null) return null;
        var result = new List<T2>();

        var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());

        foreach (var item in from)
        {
            var map = new Mapper(config);
            var tmp = map.Map<T2>(item);

            result.Add(tmp);
        }

        return result;
    }
}