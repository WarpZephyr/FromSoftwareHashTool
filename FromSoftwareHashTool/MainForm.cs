using System.Collections;
using System.Reflection;

namespace FromSoftwareHashTool
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// A string representing the path to the folder the program is running from.
        /// </summary>
        private static string? EnvFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// A string representing the path to a generic resource folder named "Resources" inside of the directory the program is running from.
        /// </summary>
        private static string ResourcesFolderPath = $"{EnvFolderPath}\\Resources";

        /// <summary>
        /// The path to the aliases file.
        /// </summary>
        private static string AliasesPath = $"{ResourcesFolderPath}\\aliases.txt";

        /// <summary>
        /// The path to the paths file.
        /// </summary>
        private static string PathsPath = $"{ResourcesFolderPath}\\paths.txt";

        /// <summary>
        /// The aliases in aliases.txt.
        /// </summary>
        private Dictionary<string, string> Aliases = new Dictionary<string, string>();

        /// <summary>
        /// The path aliases in paths.txt.
        /// </summary>
        private Dictionary<string, string> Paths = new Dictionary<string, string>();

        /// <summary>
        /// The prime for computing 32-bit hashes.
        /// </summary>
        private const uint PRIME = 37;

        /// <summary>
        /// The prime for computing 64-bit hashes.
        /// </summary>
        private const ulong PRIME64 = 0x85ul;

        public MainForm()
        {
            InitializeComponent();
            LoadAliases();
            LoadPaths();
        }

        /// <summary>
        /// Compute a 32-bit or 64-bit hash from a string.
        /// </summary>
        /// <param name="str">The string to hash.</param>
        /// <param name="bit64">Whether or not the hash is 64-bit.</param>
        /// <returns>The hash as a <see cref="ulong" /></returns>
        private static ulong ComputeHash(string str, bool bit64)
        {
            return bit64 ? str.Aggregate(0ul, (i, c) => i * PRIME64 + c) : str.Aggregate(0u, (i, c) => i * PRIME + c);
        }

        /// <summary>
        /// Load the aliases replacement dictionary.
        /// </summary>
        private void LoadAliases()
        {
            if (!string.IsNullOrEmpty(EnvFolderPath) && Directory.Exists(EnvFolderPath))
            {
                if (File.Exists(AliasesPath))
                {
                    var lines = File.ReadAllLines(AliasesPath);
                    foreach (var line in lines)
                    {
                        if (!line.Contains('='))
                            continue;
                        string[] strs = line.Split('=');
                        if (strs.Length < 2)
                            continue;
                        Aliases.Add(strs[0].Trim(), strs[1].Trim());
                    }
                }
            }
        }

        /// <summary>
        /// Load the paths replacement dictionary.
        /// </summary>
        private void LoadPaths()
        {
            if (!string.IsNullOrEmpty(EnvFolderPath) && Directory.Exists(EnvFolderPath))
            {
                if (File.Exists(PathsPath))
                {
                    var lines = File.ReadAllLines(PathsPath);
                    foreach (var line in lines)
                    {
                        if (!line.Contains('='))
                            continue;
                        string[] strs = line.Split('=');
                        if (strs.Length < 2)
                            continue;
                        Paths.Add(strs[0].Trim(), strs[1].Trim());
                    }
                }
            }
        }

        /// <summary>
        /// De-Path a string.
        /// </summary>
        /// <param name="path">The string to de-path.</param>
        /// <returns>The de-pathed string.</returns>
        private string DePath(string path)
        {
            bool found;
            do
            {
                found = false;
                foreach (string key in Paths.Keys)
                {
                    if (path.Contains(key))
                    {
                        found = true;
                        path = path.Replace(key, Paths[key]);
                    }
                }
            }
            while (found);
            return path;
        }

        /// <summary>
        /// De-Alias a string.
        /// </summary>
        /// <param name="path">The string to de-alias.</param>
        /// <returns>The de-aliased string.</returns>
        private string DeAlias(string path)
        {
            bool found;
            do
            {
                found = false;
                foreach (string key in Aliases.Keys)
                {
                    if (path.StartsWith(key))
                    {
                        found = true;
                        path = path.Replace(key, Aliases[key]);
                    }
                }
            }
            while (found);
            return path;
        }

        /// <summary>
        /// Validate a path string for hashing.
        /// </summary>
        /// <param name="str">The path string to validate.</param>
        /// <returns>A validated path string for hashing.</returns>
        private static string ValidatePath(string str)
        {
            string newStr = str.Trim().Replace('\\', '/').ToLowerInvariant();
            if (!newStr.StartsWith("/"))
                newStr = '/' + newStr;
            while (newStr.Contains("//"))
                newStr = newStr.Replace("//", "/");
            return newStr;
        }

        /// <summary>
        /// Validate the final input for hashing.
        /// </summary>
        /// <param name="str">The input for hashing.</param>
        /// <returns>The validated input for hashing.</returns>
        private string ValidateInput(string str)
        {
            return ValidatePath(DeAlias(DePath(str)));
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string str = txtInput.Text;
            if (!chxDoNotReplace.Checked)
                str = ValidateInput(str);

            txtFinalInput.Text = str;
            txtOutput.Text = ComputeHash(str, chxLong.Checked).ToString();
        }
    }
}