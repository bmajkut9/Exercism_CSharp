static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        //if (id.HasValue && department.HasValue) return $"[{id}] - {name} - {department.ToUpper()}";
        if (id == null && department != null) return $"{name} - {department.ToUpper()}";
        if (id == null && department == null) return $"{name} - OWNER";
        if (id.HasValue && department == null) return $"[{id}] - {name} - OWNER";
        return $"[{id}] - {name} - {department.ToUpper()}";
    }

    
}
