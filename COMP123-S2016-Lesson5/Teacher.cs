using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * <summary>
     * The Teacher is derived from the Person class
     * </summary>
     * 
     * @class Teacher
     * @extends Person
     */
    class Teacher : Person
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++
        private string _employeeID;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }

            set
            {
                this._employeeID = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor method takes three parameters: name, age and employeeID
         * </summary>
         * 
         * @constructor Teacher
         * @param {string} name
         * @param {int} age
         * @param {string} employeeID
         */
        public Teacher(string name, int age, string employeeID)
            : base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method enables the Teaches behaviour for the Teacher class
         * </summary>
         * 
         * @method Teaches
         * @return {void}
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }

    }
}
