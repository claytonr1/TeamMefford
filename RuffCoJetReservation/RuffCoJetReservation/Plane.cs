using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuffCoJetReservation
{
    class Plane
    {
        private int ID;
        private string name;
        private string model;
        private int capacity;
        private double range;
        private string location;
        private double speed;
        private string notes;

        public Plane(){ //default constructor, will make everything undefined because at least an ID should be given
            ID = 0;
            name = "Undefined";
            model = "Undefined";
            capacity = 0;
            range = 0;
            location = "Undefined";
            speed = 0;
            notes = "This plane was not properly initialized";
        }

        //main creation constructor
        public Plane(int _ID, string _name, string _model, int _capacity, double _range, string _location, double _speed, string _notes)
        {
            ID = _ID;
            name = _name;
            model = _model;
            capacity = _capacity;
            range = _range;
            location = _location;
            speed = _speed;
            notes = _notes;
        }

        public Plane(int _ID){ //for use in creating a new plane to later fill in the data
            ID = _ID;
        }

        public int getID(){
            return ID;
        }

        public string getName(){
            return name;
        }

        public string getModel() {
            return model;
        }

        public int getCapacity() {
            return capacity;
        }

        public double getRange() {
            return range;
        }

        public string getLocation() {
            return location;
        }

        public double getSpeed() {
            return speed;
        }

        public string getNotes(){
            return notes;
        }

    }
}
