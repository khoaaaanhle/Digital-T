//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class PlaceGoal : Message
    {
        public const string k_RosMessageName = "moveit_msgs/Place";
        public override string RosMessageName => k_RosMessageName;

        //  An action for placing an object
        //  which group to be used to plan for grasping
        public string group_name;
        //  the name of the attached object to place
        public string attached_object_name;
        //  a list of possible transformations for placing the object
        public PlaceLocationMsg[] place_locations;
        //  if the user prefers setting the eef pose (same as in pick) rather than
        //  the location of the object, this flag should be set to true
        public bool place_eef;
        //  the name that the support surface (e.g. table) has in the collision world
        //  can be left empty if no name is available
        public string support_surface_name;
        //  whether collisions between the gripper and the support surface should be acceptable
        //  during move from pre-place to place and during retreat. Collisions when moving to the
        //  pre-place location are still not allowed even if this is set to true.
        public bool allow_gripper_support_collision;
        //  Optional constraints to be imposed on every point in the motion plan
        public ConstraintsMsg path_constraints;
        //  The name of the motion planner to use. If no name is specified,
        //  a default motion planner will be used
        public string planner_id;
        //  an optional list of obstacles that we have semantic information about
        //  and that can be touched/pushed/moved in the course of placing
        public string[] allowed_touch_objects;
        //  The maximum amount of time the motion planner is allowed to plan for
        public double allowed_planning_time;
        //  Planning options
        public PlanningOptionsMsg planning_options;

        public PlaceGoal()
        {
            this.group_name = "";
            this.attached_object_name = "";
            this.place_locations = new PlaceLocationMsg[0];
            this.place_eef = false;
            this.support_surface_name = "";
            this.allow_gripper_support_collision = false;
            this.path_constraints = new ConstraintsMsg();
            this.planner_id = "";
            this.allowed_touch_objects = new string[0];
            this.allowed_planning_time = 0.0;
            this.planning_options = new PlanningOptionsMsg();
        }

        public PlaceGoal(string group_name, string attached_object_name, PlaceLocationMsg[] place_locations, bool place_eef, string support_surface_name, bool allow_gripper_support_collision, ConstraintsMsg path_constraints, string planner_id, string[] allowed_touch_objects, double allowed_planning_time, PlanningOptionsMsg planning_options)
        {
            this.group_name = group_name;
            this.attached_object_name = attached_object_name;
            this.place_locations = place_locations;
            this.place_eef = place_eef;
            this.support_surface_name = support_surface_name;
            this.allow_gripper_support_collision = allow_gripper_support_collision;
            this.path_constraints = path_constraints;
            this.planner_id = planner_id;
            this.allowed_touch_objects = allowed_touch_objects;
            this.allowed_planning_time = allowed_planning_time;
            this.planning_options = planning_options;
        }

        public static PlaceGoal Deserialize(MessageDeserializer deserializer) => new PlaceGoal(deserializer);

        private PlaceGoal(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.group_name);
            deserializer.Read(out this.attached_object_name);
            deserializer.Read(out this.place_locations, PlaceLocationMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.place_eef);
            deserializer.Read(out this.support_surface_name);
            deserializer.Read(out this.allow_gripper_support_collision);
            this.path_constraints = ConstraintsMsg.Deserialize(deserializer);
            deserializer.Read(out this.planner_id);
            deserializer.Read(out this.allowed_touch_objects, deserializer.ReadLength());
            deserializer.Read(out this.allowed_planning_time);
            this.planning_options = PlanningOptionsMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.group_name);
            serializer.Write(this.attached_object_name);
            serializer.WriteLength(this.place_locations);
            serializer.Write(this.place_locations);
            serializer.Write(this.place_eef);
            serializer.Write(this.support_surface_name);
            serializer.Write(this.allow_gripper_support_collision);
            serializer.Write(this.path_constraints);
            serializer.Write(this.planner_id);
            serializer.WriteLength(this.allowed_touch_objects);
            serializer.Write(this.allowed_touch_objects);
            serializer.Write(this.allowed_planning_time);
            serializer.Write(this.planning_options);
        }

        public override string ToString()
        {
            return "PlaceGoal: " +
            "\ngroup_name: " + group_name.ToString() +
            "\nattached_object_name: " + attached_object_name.ToString() +
            "\nplace_locations: " + System.String.Join(", ", place_locations.ToList()) +
            "\nplace_eef: " + place_eef.ToString() +
            "\nsupport_surface_name: " + support_surface_name.ToString() +
            "\nallow_gripper_support_collision: " + allow_gripper_support_collision.ToString() +
            "\npath_constraints: " + path_constraints.ToString() +
            "\nplanner_id: " + planner_id.ToString() +
            "\nallowed_touch_objects: " + System.String.Join(", ", allowed_touch_objects.ToList()) +
            "\nallowed_planning_time: " + allowed_planning_time.ToString() +
            "\nplanning_options: " + planning_options.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Goal);
        }
    }
}
