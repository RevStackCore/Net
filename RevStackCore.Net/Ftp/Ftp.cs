using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using CoreFtp;

namespace RevStackCore.Net
{
	public class Ftp
	{

		private string _host;
		private string _username;
		private string _password;
		private int _port;
		private FtpEncryption _encryption;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.Ftp"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public Ftp(string host, string username, string password)
		{
			_host = host;
			_username = username;
			_password = password;
			_port = 21;
			_encryption = FtpEncryption.Implicit;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.Ftp"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="port">Port.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public Ftp(string host, int port, string username, string password)
		{
			_host = host;
			_username = username;
			_password = password;
			_port = port;
			_encryption = FtpEncryption.Implicit;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.Ftp"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="encryption">Encryption.</param>
		public Ftp(string host, string username, string password, FtpEncryption encryption)
		{
			_host = host;
			_username = username;
			_password = password;
			_port = 21;
			_encryption = encryption;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.Ftp"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="port">Port.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="encryption">Encryption.</param>
		public Ftp(string host, int port, string username, string password, FtpEncryption encryption)
		{
			_host = host;
			_username = username;
			_password = password;
			_port = port;
			_encryption = encryption;
		}


		/// <summary>
		/// Uploads the file.
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="source">Source.</param>
		/// <param name="destination">Destination.</param>
		public async Task<bool> UploadFile(string source, string destination)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					var fileinfo = new FileInfo(source);
					using (var writeStream = await ftpClient.OpenFileWriteStreamAsync(destination))
					{
						var fileReadStream = fileinfo.OpenRead();
						await fileReadStream.CopyToAsync(writeStream);
					}
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}


		/// <summary>
		/// Deletes the file.
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="file">File.</param>
		public async Task<bool> DeleteFile(string file)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.DeleteFileAsync(file);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Downloads the file.
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="source">Source.</param>
		/// <param name="dest">Destination.</param>
		public async Task<bool> DownloadFile(string source, string dest)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					var tempFile = new FileInfo(dest);
					await ftpClient.LoginAsync();
					using (var ftpReadStream = await ftpClient.OpenFileReadStreamAsync("test.png"))
					{
						using (var fileWriteStream = tempFile.OpenWrite())
						{
							await ftpReadStream.CopyToAsync(fileWriteStream);
						}
					}
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Lists the files async.
		/// </summary>
		/// <returns>files list async</returns>
		/// <param name="directory">Directory.</param>
		public async Task<IEnumerable<string>> ListFilesAsync(string directory)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.ChangeWorkingDirectoryAsync(directory);
					var files = await ftpClient.ListFilesAsync();
					return files.Select(x => x.Name);
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Details the list files async.
		/// </summary>
		/// <returns>The list files async.</returns>
		/// <param name="directory">Directory.</param>
		public async Task<IEnumerable<FtpFileAttribute>> DetailListFilesAsync(string directory)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.ChangeWorkingDirectoryAsync(directory);
					var files = await ftpClient.ListFilesAsync();
					return files.Select(x => new FtpFileAttribute
					{
						Name = x.Name,
						Size = x.Size,
						DateModified = x.DateModified
					});
				}
			}
			catch (Exception)
			{
				return null;
			}
		}


		/// <summary>
		/// Lists the directories async.
		/// </summary>
		/// <returns>The directories async.</returns>
		public async Task<IEnumerable<string>> ListDirectoriesAsync()
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					var directories = await ftpClient.ListDirectoriesAsync();
					return directories.Select(x => x.Name);
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Details the list directories async.
		/// </summary>
		/// <returns>The list directories async.</returns>
		public async Task<IEnumerable<FtpFileAttribute>> DetailListDirectoriesAsync()
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					var directories = await ftpClient.ListDirectoriesAsync();
					return directories.Select(x => new FtpFileAttribute
					{
						Name = x.Name,
						Size = x.Size,
						DateModified = x.DateModified
					});
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Changes the directory.
		/// </summary>
		/// <returns>The directory.</returns>
		/// <param name="directory">Directory.</param>
		public async Task<bool> ChangeDirectory(string directory)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.ChangeWorkingDirectoryAsync(directory);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Makes the directory.
		/// </summary>
		/// <returns>The directory.</returns>
		/// <param name="directory">Directory.</param>
		public async Task<bool> MakeDirectory(string directory)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.CreateDirectoryAsync(directory);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}


		/// <summary>
		/// Removes the directory.
		/// </summary>
		/// <returns>The directory.</returns>
		/// <param name="directory">Directory.</param>
		public async Task<bool> RemoveDirectory(string directory)
		{
			try
			{
				using (var ftpClient = new FtpClient(clientConfiguration()))
				{
					await ftpClient.LoginAsync();
					await ftpClient.DeleteDirectoryAsync(directory);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Clients the configuration.
		/// </summary>
		/// <returns>The configuration.</returns>
		private FtpClientConfiguration clientConfiguration()
		{
			return new FtpClientConfiguration
			{
				Host = _host,
				Username = _username,
				Password = _password,
				Port = _port,
				EncryptionType = _encryption.ToCoreFTPEncryption(),
				IgnoreCertificateErrors = true
			};
		}

		/// <summary>
		/// Combine the specified path1 and path2.
		/// </summary>
		/// <returns>The combine.</returns>
		/// <param name="path1">Path1.</param>
		/// <param name="path2">Path2.</param>
		private string combine(string path1, string path2)
		{
			return Path.Combine(path1, path2).Replace("\\", "/");
		}

	}
}
