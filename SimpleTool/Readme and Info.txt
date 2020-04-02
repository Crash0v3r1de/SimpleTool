====Encryption system and function ideas====
ConKey in client config can store the configured one time client key config for auth purposes - Connection Key
EncryptionKeys in client config will store the usable encryption keys - Stored Encryption Keys

On new client connect verify it is a slave stub of ours (send something specific to verify i guess?) - could check the stub pass, salt, and connection key stored in it
Send the current/updated SHA256 salt and pass via built in sha256 connection pass and salt (configured during stub compile)
Encrypt anything being sent to the stub/slave with the current/new SHA256 details we sent upon auth











====Documentation====
This will contain all info about specific functions, storage configs, and anything else process/workflow wise i've done in the bot.


---EncryptionKeys Client Config Storage---
Pass and salt will be stored plain text via app config json file. The pass and salt will be stoed in a json array like format for the key class.
Upon loading the keys into the program the json deserializer will place them all in a list of EncryptionKey class inside the ClientConfig class.
We can itirate through the list easier this way as well as storage.

---Server handling of Stub Connection |  Step by step breakdown---
(NOTE: all of sent items will be encrypted with default/first time pass,salt,vl key until new keys sent and that will be used in memory as secure strings - guess?)
(Vl key will NOT be sent)
---NOT PART OF AUTH STEPS---
0.) Stub sends base64(hostname:WAN_IP)

---AUTH STEPS---
1.) Recieve connection key - server verifies key is correct
2.) Recieve encryption pass and salt (pass:salt format) - server verifies they are stored in the list of accepted keys (it should be default key)
3.) Server sends stub updated/changed/new keys to store to use this session. format to send keys (pass:salt:xorKey)
BEFORE WE SEND NEW KEYS! - If server Anti VM enabled - Stub sends "AUSSIEAUSSIEAUSSIE" for stub to handle
Send GOOD if we are just going to use the built in static keys - not recommended
send new pass:salt:xorKey for normal use

---Client Handling of Server Connection | Step by step breakdown---
---NOT PART OF AUTH STEPS---
0.) Send clientID base64(hostname:WAN_IP)

---AUTH STEPS---
1.) Sends connection key - server verifies key is correct
2.) Sends encryption pass and salt (pass:salt format) - server verifies they are stored in the list of accepted keys (it should be default key)
3.) Server sends stub updated/changed/new keys to use this session. format to send keys (pass:salt:xorKey)
BEFORE WE SEND NEW KEYS! - If server Anti VM enabled - Stub sends "AUSSIEAUSSIEAUSSIE" and if its VM it will kill itself
Recieve GOOD and stub will use the built in static keys
pass:salt:xorKey for normal use will be last dealt with if none of the other results are sent