namespace BlazorApp1.Data
{
    public class WrapData
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public int Progress { get; set; }
        public string Priority { get; set; }
        public bool Approved { get; set; }
        public int Resources { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; } // Add this property for description
        public string Category { get; set; }    // Add this property for category
        public List<WrapData> Subtasks { get; set; } // Add this property for subtasks

        // Sample data for TreeGrid
        public static List<WrapData> GetSampleData()
        {
            return new List<WrapData>
    {
        new WrapData
        {
            TaskID = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2017, 2, 3),
            EndDate = new DateTime(2017, 2, 7),
            Duration = 5,
            Progress = 100,
            Priority = "Normal",
            Approved = false,
            Description = "Task description 1",
            Category = "Task category 1",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 2,
                    TaskName = "Plan timeline",
                    StartDate = new DateTime(2017, 2, 3),
                    EndDate = new DateTime(2017, 2, 7),
                    Duration = 5,
                    Progress = 100,
                    Priority = "Normal",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 3,
                    TaskName = "Plan budget",
                    StartDate = new DateTime(2017, 2, 3),
                    EndDate = new DateTime(2017, 2, 7),
                    Duration = 5,
                    Progress = 100,
                    Priority = "Low",
                    Approved = true
                },
                new WrapData
                {
                    TaskID = 4,
                    TaskName = "Allocate resources",
                    StartDate = new DateTime(2017, 2, 3),
                    EndDate = new DateTime(2017, 2, 7),
                    Duration = 5,
                    Progress = 100,
                    Priority = "Critical",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 5,
                    TaskName = "Planning complete",
                    StartDate = new DateTime(2017, 2, 7),
                    EndDate = new DateTime(2017, 2, 7),
                    Duration = 0,
                    Progress = 0,
                    Priority = "Low",
                    Approved = true
                }
            }
        },
        new WrapData
        {
            TaskID = 6,
            TaskName = "Design",
            StartDate = new DateTime(2017, 2, 10),
            EndDate = new DateTime(2017, 2, 14),
            Duration = 3,
            Progress = 86,
            Priority = "High",
            Approved = false,
            Description = "Task description 2",
            Category = "Task category 2",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 7,
                    TaskName = "Software Specification",
                    StartDate = new DateTime(2017, 2, 10),
                    EndDate = new DateTime(2017, 2, 12),
                    Duration = 3,
                    Progress = 60,
                    Priority = "Normal",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 8,
                    TaskName = "Develop prototype",
                    StartDate = new DateTime(2017, 2, 10),
                    EndDate = new DateTime(2017, 2, 12),
                    Duration = 3,
                    Progress = 100,
                    Priority = "Critical",
                    Approved = false
                }
            }
        },
        // New Task 1
        new WrapData
        {
            TaskID = 9,
            TaskName = "Implementation",
            StartDate = new DateTime(2017, 2, 15),
            EndDate = new DateTime(2017, 2, 20),
            Duration = 5,
            Progress = 50,
            Priority = "High",
            Approved = false,
            Description = "Task description 3",
            Category = "Task category 3",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 10,
                    TaskName = "Develop code",
                    StartDate = new DateTime(2017, 2, 15),
                    EndDate = new DateTime(2017, 2, 17),
                    Duration = 3,
                    Progress = 70,
                    Priority = "High",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 11,
                    TaskName = "Code review",
                    StartDate = new DateTime(2017, 2, 18),
                    EndDate = new DateTime(2017, 2, 20),
                    Duration = 2,
                    Progress = 30,
                    Priority = "Normal",
                    Approved = false
                }
            }
        },
        // New Task 2
        new WrapData
        {
            TaskID = 12,
            TaskName = "Testing",
            StartDate = new DateTime(2017, 2, 21),
            EndDate = new DateTime(2017, 2, 25),
            Duration = 4,
            Progress = 40,
            Priority = "Medium",
            Approved = false,
            Description = "Task description 4",
            Category = "Task category 4",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 13,
                    TaskName = "Unit testing",
                    StartDate = new DateTime(2017, 2, 21),
                    EndDate = new DateTime(2017, 2, 22),
                    Duration = 2,
                    Progress = 50,
                    Priority = "High",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 14,
                    TaskName = "Integration testing",
                    StartDate = new DateTime(2017, 2, 23),
                    EndDate = new DateTime(2017, 2, 25),
                    Duration = 2,
                    Progress = 30,
                    Priority = "Medium",
                    Approved = false
                }
            }
        },
        // New Task 3
        new WrapData
        {
            TaskID = 15,
            TaskName = "Deployment",
            StartDate = new DateTime(2017, 2, 26),
            EndDate = new DateTime(2017, 2, 28),
            Duration = 3,
            Progress = 10,
            Priority = "Critical",
            Approved = false,
            Description = "Task description 5",
            Category = "Task category 5",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 16,
                    TaskName = "Prepare deployment environment",
                    StartDate = new DateTime(2017, 2, 26),
                    EndDate = new DateTime(2017, 2, 27),
                    Duration = 2,
                    Progress = 40,
                    Priority = "High",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 17,
                    TaskName = "Deploy to production",
                    StartDate = new DateTime(2017, 2, 28),
                    EndDate = new DateTime(2017, 2, 28),
                    Duration = 1,
                    Progress = 0,
                    Priority = "Critical",
                    Approved = false
                }
            }
        },
        // New Task 4
        new WrapData
        {
            TaskID = 18,
            TaskName = "Maintenance",
            StartDate = new DateTime(2017, 3, 1),
            EndDate = new DateTime(2017, 3, 5),
            Duration = 5,
            Progress = 20,
            Priority = "Low",
            Approved = false,
            Description = "Task description 6",
            Category = "Task category 6",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 19,
                    TaskName = "Monitor system",
                    StartDate = new DateTime(2017, 3, 1),
                    EndDate = new DateTime(2017, 3, 3),
                    Duration = 3,
                    Progress = 50,
                    Priority = "Normal",
                    Approved = false
                },
                new WrapData
                {
                    TaskID = 20,
                    TaskName = "Fix bugs",
                    StartDate = new DateTime(2017, 3, 4),
                    EndDate = new DateTime(2017, 3, 5),
                    Duration = 2,
                    Progress = 10,
                    Priority = "Low",
                    Approved = false
                }
            }
        },
        // New Task 5
        new WrapData
        {
            TaskID = 21,
            TaskName = "Documentation",
            StartDate = new DateTime(2017, 3, 6),
            EndDate = new DateTime(2017, 3, 8),
            Duration = 3,
            Progress = 70,
            Priority = "Normal",
            Approved = true,
            Description = "Task description 7",
            Category = "Task category 7",
            Subtasks = new List<WrapData>
            {
                new WrapData
                {
                    TaskID = 22,
                    TaskName = "Write user guide",
                    StartDate = new DateTime(2017, 3, 6),
                    EndDate = new DateTime(2017, 3, 7),
                    Duration = 2,
                    Progress = 80,
                    Priority = "Normal",
                    Approved = true
                },
                new WrapData
                {
                    TaskID = 23,
                    TaskName = "Write API documentation",
                    StartDate = new DateTime(2017, 3, 7),
                    EndDate = new DateTime(2017, 3, 8),
                    Duration = 2,
                    Progress = 60,
                    Priority = "Normal",
                    Approved = true
                }
            }
        }
    };
        }

    }
}
