using System;
using Nuke.Common.IO;

static class StaticMethods
{
    public static AbsolutePath CopyToDirectory(AbsolutePath source, AbsolutePath target,
        ExistsPolicy policy = ExistsPolicy.Fail,
        Func<AbsolutePath, bool> excludeDirectory = null,
        Func<AbsolutePath, bool> excludeFile = null,
        bool createDirectories = true)
    {
        return source.CopyToDirectory(target, policy, excludeDirectory, excludeFile, createDirectories);
    }

    public static AbsolutePath Copy(AbsolutePath source, AbsolutePath target,
        ExistsPolicy policy = ExistsPolicy.Fail,
        Func<AbsolutePath, bool> excludeDirectory = null,
        Func<AbsolutePath, bool> excludeFile = null,
        bool createDirectories = true)
    {
        return source.Copy(target, policy, excludeDirectory, excludeFile, createDirectories);
    }

}