using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		/// <summary>
		/// Create
		/// </summary>
		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				//Models.User newUser = new Models.User();

				//newUser.Age = 30,
				//newUser.Username = "Dariush";
				//newUser.Password = "1234512345";
				//newUser.EmailAddress = "DariushT@GMail.com";
				// **************************************************

				// **************************************************
				//Models.User newUser = new Models.User
				//{
				//	Age = 30,
				//	Username = "Dariush",
				//	Password = "1234512345",
				//	EmailAddress = "DariushT@GMail.com"
				//};
				// **************************************************

				// **************************************************
				Models.User newUser = new Models.User
				{
					Age = 30,
					Username = "Dariush",
					Password = "1234512345",
					EmailAddress = "DariushT@GMail.com",
				};
				// **************************************************

				// **************************************************
				//Models.User newUser = new Models.User
				//{
				//	Username = usernameTextBox.Text,
				//	Password = passwordTextBox.Text,
				//	EmailAddress = emailAddressTextBox.Text,
				//};
				// **************************************************

				databaseContext.Users.Add(newUser);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Retrieve:
		/// Zero or Many
		/// </summary>
		private void GetUsersButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// ToList() -> using System.Linq;

				//var users = databaseContext.Users.ToList();

				// "SELECT * FROM Users"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.ToList()
				//	;

				// "SELECT * FROM Users"
				// **************************************************

				// **************************************************
				//System.Collections.Generic.List<Models.User> users =
				//	databaseContext.Users
				//	.ToList()
				//	;

				// "SELECT * FROM Users"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.Where(current => current.Age > 20)
				//	.ToList()
				//	;

				// "SELECT * FROM Users WHERE Age > 20"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.Where(current => current.Age > 20)
				//	.Where(current => current.Age < 30)
				//	.ToList()
				//	;

				//var users =
				//	databaseContext.Users
				//	.Where(current => current.Age > 20 && current.Age < 30)
				//	.ToList()
				//	;

				// "SELECT * FROM Users WHERE Age > 20 AND Age < 30"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.OrderBy(current => current.FullName)
				//	.ToList()
				//	;

				// "SELECT * FROM Users ORDER BY FullName"
				// "SELECT * FROM Users ORDER BY FullName ASC"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.OrderByDescending(current => current.FullName)
				//	.ToList()
				//	;

				// "SELECT * FROM Users ORDER BY FullName DESC"
				// **************************************************

				// **************************************************
				// Note: Wrong Usage!

				//var users =
				//	databaseContext.Users
				//	.OrderBy(current => current.Age)
				//	.OrderBy(current => current.FullName)
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.OrderBy(current => current.Age)
				//	.ThenBy(current => current.FullName)
				//	.ToList()
				//	;

				// "SELECT * FROM Users ORDER BY Age, FullName"
				// "SELECT * FROM Users ORDER BY Age ASC, FullName ASC"
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.OrderBy(current => current.Age)
				//	.ThenByDescending(current => current.FullName)
				//	.ToList()
				//	;

				// "SELECT * FROM Users ORDER BY Age, FullName DESC"
				// "SELECT * FROM Users ORDER BY Age ASC, FullName DESC"
				// **************************************************

				// **************************************************
				// Note: Wrong Usage!

				//var users =
				//	databaseContext.Users
				//	.OrderBy(current => current.FullName)
				//	.Where(current => current.Age > 20)
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				var users =
					databaseContext.Users
					.Where(current => current.Age > 20)
					.OrderBy(current => current.FullName)
					.ToList()
					;

				// "SELECT * FROM Users WHERE Age > 20 ORDER BY FullName"
				// "SELECT * FROM Users WHERE Age > 20 ORDER BY FullName ASC"
				// **************************************************

				// **************************************************
				//usersListBox.DataSource = users;
				//usersListBox.ValueMember = "Id";
				//usersListBox.DisplayMember = "Username";
				// **************************************************

				// **************************************************
				usersListBox.DataSource = users;
				usersListBox.ValueMember = nameof(Models.User.Id);
				usersListBox.DisplayMember = nameof(Models.User.Username);
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Retrieve:
		/// Zero or One
		/// </summary>
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Note: Not Recommended!

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => current.Username == "Dariush")
				//	.First();
				// **************************************************

				// **************************************************
				// Note: Not Recommended!

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => current.Username == "Dariush")
				//	.Single();
				// **************************************************

				// **************************************************
				// Note: Not Recommended!

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => current.Username == "Dariush")
				//	.FirstOrDefault();
				// **************************************************

				// **************************************************
				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, "Dariush", true) == 0)
					.FirstOrDefault();
				// **************************************************

				// **************************************************
				// Note: Not Recommended!

				//Models.User user =
				//	databaseContext.Users
				//	.FirstOrDefault(current => string.Compare(current.Username, "Dariush", true) == 0);
				// **************************************************

				string errorMessage = string.Empty;

				if (user == null)
				{
					//errorMessage = "Invalid username!";

					errorMessage =
						"Invalid username and/or password!";
				}
				else
				{
					if (string.Compare(user.Password, "1234512345", ignoreCase: false) != 0)
					{
						//errorMessage = "Invalid password!";

						errorMessage =
							"Invalid username and/or password!";
					}
					else
					{
						if (user.IsActive == false)
						{
							errorMessage =
								"You can not login at this time! Please contant support...";
						}
					}
				}

				if (string.IsNullOrWhiteSpace(errorMessage))
				{
					System.Windows.Forms.MessageBox.Show($"Welcome { user.Username }!");
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(errorMessage);
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string username = "Dariush";

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, username, true) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					string errorMessage =
						$"There is not any user with this username [{ username }] for updating!";

					System.Windows.Forms.MessageBox.Show(errorMessage);

					return;
				}

				user.IsActive = !user.IsActive;

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("User updated successfully...");
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Delete
		/// </summary>
		private void DeleteButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string username = "Dariush";

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, username, true) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					string errorMessage =
						$"There is not any user with this username [{ username }] for deleting!";

					System.Windows.Forms.MessageBox.Show(errorMessage);

					return;
				}

				databaseContext.Users.Remove(user);

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("User deleted successfully...");
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
