#include <fstream>

#include "ns3/core-module.h"

#include "ns3/csma-module.h"

#include "ns3/applications-module.h"

#include "ns3/internet-module.h"
 //netAnimation
#include "ns3/netanim-module.h"

#include "ns3/mobility-module.h"

using namespace ns3;
NS_LOG_COMPONENT_DEFINE("UdpClientServerExample");
int
main(int argc, char * argv[]) {
  //
  // Enable logging for UdpClient and
  //
  LogComponentEnable("UdpClient", LOG_LEVEL_INFO);
  LogComponentEnable("UdpServer", LOG_LEVEL_INFO);
  bool useV6 = false;
  Address serverAddress;
  CommandLine cmd(__FILE__);
  cmd.AddValue("useIpv6", "Use Ipv6", useV6);
  cmd.Parse(argc, argv);
  //
  // Explicitly create the nodes required by the topology (shown above).
  //
  NS_LOG_INFO("Create nodes.");
  NodeContainer n;
  n.Create(2);
  InternetStackHelper internet;
  internet.Install(n);
  NS_LOG_INFO("Create channels.");
  //
  // Explicitly create the channels required by the topology (shown above).
  //
  CsmaHelper csma;
  csma.SetChannelAttribute("DataRate", DataRateValue(DataRate(5000000)));
  csma.SetChannelAttribute("Delay", TimeValue(MilliSeconds(2)));
  csma.SetDeviceAttribute("Mtu", UintegerValue(1400));
  NetDeviceContainer d = csma.Install(n);
  //
  // We've got the "hardware" in place. Now we need to add IP addresses.
  //
  NS_LOG_INFO("Assign IP Addresses.");
  if (useV6 == false) {
    Ipv4AddressHelper ipv4;
    ipv4.SetBase("10.1.1.0", "255.255.255.0");
    Ipv4InterfaceContainer i = ipv4.Assign(d);
    serverAddress = Address(i.GetAddress(1));
  } else {
    Ipv6AddressHelper ipv6;
    ipv6.SetBase("2001:0000:f00d:cafe::", Ipv6Prefix(64));
    Ipv6InterfaceContainer i6 = ipv6.Assign(d);
    serverAddress = Address(i6.GetAddress(1, 1));
  }
  NS_LOG_INFO("Create Applications.");
  //
  // Create one udpServer applications on node one.
  //
  uint16_t port = 4000;
  UdpServerHelper server(port);
  ApplicationContainer apps = server.Install(n.Get(1));
  apps.Start(Seconds(1.0));
  apps.Stop(Seconds(10.0));
  //
  // Create one UdpClient application to send UDP datagrams from node zero to
  // node one.
  //
  uint32_t MaxPacketSize = 1024;
  Time interPacketInterval = Seconds(0.05);
  uint32_t maxPacketCount = 320;
  UdpClientHelper client(serverAddress, port);
  client.SetAttribute("MaxPackets", UintegerValue(maxPacketCount));
  client.SetAttribute("Interval", TimeValue(interPacketInterval));
  client.SetAttribute("PacketSize", UintegerValue(MaxPacketSize));
  apps = client.Install(n.Get(0));
  apps.Start(Seconds(2.0));
  apps.Stop(Seconds(10.0));
  AnimationInterface anim("6_udp.xml");
  AnimationInterface::SetConstantPosition(n.Get(0), 10, 25);
  AnimationInterface::SetConstantPosition(n.Get(1), 40, 25);
  anim.EnablePacketMetadata(true);
  csma.EnablePcapAll("udp-cs");
  //
  // Now, do the actual simulation.
  //
  NS_LOG_INFO("Run Simulation.");
  Simulator::Run();
  Simulator::Destroy();
  NS_LOG_INFO("Done.");
}
