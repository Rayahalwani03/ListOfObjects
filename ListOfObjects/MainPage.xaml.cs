namespace ListOfObjects
{
    public partial class MainPage : ContentPage
    {
       
        public List<studentClass> StudentList = new List<studentClass>();
        public MainPage()
        {
            InitializeComponent();

           

            StudentList.Add(new studentClass(1,"AA","AAA"));
            StudentList.Add(new studentClass(2, "BB", "BBB"));
            StudentList.Add(new studentClass(3, "CC", "CCC"));



            Stu_List_View.ItemsSource = StudentList;


        }

        private async void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var student = e.Item as studentClass;

            await DisplayAlert("Selected Student", "Student Name:" +

                student.id.ToString(), "Ok"
                
                );
        }

        private void Add_Btn_Clicked(object sender, EventArgs e)
        {

            int ID;
            int.TryParse(Stu_id.Text, out ID);
            StudentList.Add(new studentClass(ID, Stu_name.Text, Stu_department.Text));
            Stu_List_View.ItemsSource = null;
            Stu_List_View.ItemsSource = StudentList;

        }
    }

}
