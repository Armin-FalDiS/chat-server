import socket
import sys
from threading import Thread

userList = {}

class user(Thread):

    def __init__(self, conn, addr):
        Thread.__init__(self)
        self.sock = conn
        self.addr = addr
        self.nickname = ''
        self.start()

    def run(self):
        while 1:
            try:
                data = self.sock.recv(1024).decode()
                if not data:
                    self.sock.close()
                    break
                # login
                if(data[0] == '$'):
                    name = data[1:]
                    userList[name] = self
                    self.nickname = name
                    print(userList)
                # fetch user list
                if(data == '_userlist'):
                    users = '#'
                    for user in userList.keys():
                        users += user + ','
                    self.sock.send(users[0:-1].encode())
                # send IM to @user
                if(data[0] == '@'):
                    startOfBody = data.find(':') + 1
                    to = data[1:startOfBody - 1]
                    body = data[startOfBody:]
                    userList[to].sock.send(('@' + self.nickname + ':' + body).encode())
            except ConnectionError:
                print("User " + self.nickname + " has disconnected")
                self.sock.close()
                userList.pop(self.nickname)
                break
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.bind(('', 1375))
sock.listen()

print('Server started on port 1375')

while 1:
    conn, addr = sock.accept()
    print('New user @' + addr[0])
    user(conn, addr)

sock.close()