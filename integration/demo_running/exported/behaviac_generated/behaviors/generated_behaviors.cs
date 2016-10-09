// ---------------------------------------------------------------------
// This file is auto-generated by behaviac designer, so please don't modify it by yourself!
// Export file: exported/behaviac_generated/behaviors/generated_behaviors.cs
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace behaviac
{
	// Source file: demo_running

	[behaviac.GeneratedTypeMetaInfo()]
	class DecoratorLoop_bt_demo_running_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_demo_running_node0()
		{
			m_bDecorateWhenChildEnds = true;
			m_bDoneWithinFrame = false;
		}
		protected override int GetCount(Agent pAgent)
		{
			return 3;
		}
	}

	[behaviac.GeneratedTypeMetaInfo()]
	class Condition_bt_demo_running_node2 : behaviac.Condition
	{
		public Condition_bt_demo_running_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			bool opl = (bool)((CBTPlayer)pAgent).Condition();
			bool opr = true;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	[behaviac.GeneratedTypeMetaInfo()]
	class Action_bt_demo_running_node3 : behaviac.Action
	{
		public Action_bt_demo_running_node3()
		{
			this.m_resultOption = EBTStatus.BT_INVALID;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((CBTPlayer)pAgent).Action1();
			return result;
		}
	}

	[behaviac.GeneratedTypeMetaInfo()]
	class Action_bt_demo_running_node4 : behaviac.Action
	{
		public Action_bt_demo_running_node4()
		{
			this.m_resultOption = EBTStatus.BT_INVALID;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((CBTPlayer)pAgent).Action3();
			return result;
		}
	}

	public static class bt_demo_running
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("demo_running");
			bt.IsFSM = false;
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("CBTPlayer");
#endif
			// children
			{
				DecoratorLoop_bt_demo_running_node0 node0 = new DecoratorLoop_bt_demo_running_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("CBTPlayer");
#endif
				bt.AddChild(node0);
				{
					Sequence node1 = new Sequence();
					node1.SetClassNameString("Sequence");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("CBTPlayer");
#endif
					node0.AddChild(node1);
					{
						Condition_bt_demo_running_node2 node2 = new Condition_bt_demo_running_node2();
						node2.SetClassNameString("Condition");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("CBTPlayer");
#endif
						node1.AddChild(node2);
						node1.SetHasEvents(node1.HasEvents() | node2.HasEvents());
					}
					{
						Action_bt_demo_running_node3 node3 = new Action_bt_demo_running_node3();
						node3.SetClassNameString("Action");
						node3.SetId(3);
#if !BEHAVIAC_RELEASE
						node3.SetAgentType("CBTPlayer");
#endif
						node1.AddChild(node3);
						node1.SetHasEvents(node1.HasEvents() | node3.HasEvents());
					}
					{
						Action_bt_demo_running_node4 node4 = new Action_bt_demo_running_node4();
						node4.SetClassNameString("Action");
						node4.SetId(4);
#if !BEHAVIAC_RELEASE
						node4.SetAgentType("CBTPlayer");
#endif
						node1.AddChild(node4);
						node1.SetHasEvents(node1.HasEvents() | node4.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

}