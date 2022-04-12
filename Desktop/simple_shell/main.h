#ifndef MAIN.H
#define MAIN.H

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <stddef.h>
#include <string.h>
#include <sys/wait.h>
#include <signal.h>
#include <stdarg.h>
#include <sys.wait.h>

int main(int ac, char **ar, char *envp[]);
int _exec(int ac, char *av[]);
int print_e(char **envp);
int_strcmp(char *s1, char *s2);
int_strlen(shar *s);
void  _signal(int line);
void _split(char *buffer, char **av);

extern char **environ;

#endif /* _MAIN_H_ */
