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
		private void Register()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User newUser = new Models.User();

				newUser.Username = "Dariush";
				newUser.Password = "1234512345";
				newUser.EmailAddress = "DariushT@GMail.com";

				//newUser.Username = usernameTextBox.Text;
				//newUser.Password = passwordTextBox.Text;
				//newUser.EmailAddress = emailAddressTextBox.Text;

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
					databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Retrieve:
		/// Zero or Many
		/// </summary>
		private void GetUsers()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				//var users =
				//	databaseContext.Users.ToList();

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
		private void Login()
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

				//Models.User oUser =
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
						else
						{
							// ...
						}
					}
				}

				System.Windows.Forms.MessageBox.Show(errorMessage);
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
		private void UpdateProfile()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// ASP.NET Web Form [OR] ASP.NET MVC: Session["UserId"]
				// Windows Form Application [OR] WPF: Infrastructure.Utility.AuthenticatedUser.UserId
				System.Guid userId = System.Guid.NewGuid();

				Models.User user =
					databaseContext.Users
					.Where(current => current.Id == userId)
					.FirstOrDefault();

				if (user == null)
				{
					string errorMessage =
						"Your information has been deleted!";

					System.Windows.Forms.MessageBox.Show(errorMessage);

					System.Windows.Forms.Application.Exit();

					return;
				}

				user.Age = 42;
				user.FullName = "Mr. Dariush Tasdighi";

				//user.Age = ageTextBox.Text;
				//user.FullName = fullNameTextBox.Text;

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
					databaseContext = null;
				}
			}
		}

		/// <summary>
		/// Delete
		/// </summary>
		private void DeleteUser()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, "Dariush", true) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					string errorMessage =
						"There is not any user with this username for deleting!";

					System.Windows.Forms.MessageBox.Show(errorMessage);

					return;
				}

				databaseContext.Users.Remove(user);

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
					databaseContext = null;
				}
			}
		}
	}
}
