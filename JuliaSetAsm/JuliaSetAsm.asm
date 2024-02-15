.data
    szer dq 502
    wys dq 450
    one_point_five dq 1.5
    zero_point_five dq 0.5
    two dq 2.0
    four dq 4.0
    zero dq 0.0
    ;array dd 502*450 dup(?)

    ;RCX/XMM0 = output[]
    ;XMM1 = realPart 0.4
    ;XMM2 = imgPart 0.15
    ;R9 = maxIter
    ;RDI = y 
    ;RSI = x
    

.code
julia proc
    xor r11, r11
    xor rdi, rdi
    xor rsi, rsi

y_loop:
    cmp rdi, [wys]
    jge end_y_loop

x_loop:
    cmp rsi, [szer]
    jge end_x_loop
    cvtsi2sd xmm5, [szer]           ; (502)
    mulsd xmm5, [zero_point_five]   ; (0.5 * 502)

    cvtsi2sd xmm6, rsi              ; (x)
    cvtsi2sd xmm7, [szer]           ; (502)
    divsd xmm7, [two]               ; (502/2)
    subsd xmm6, xmm7                ; (x - 502/2)

    movsd xmm8, [one_point_five]    ; (1.5)
    divsd xmm6, xmm5                ; (x - 502/2) / (0.5 * 502)
    mulsd xmm8, xmm6                ; zx = 1.5 * (x - 502/2) / (0.5 * width)
    
    cvtsi2sd xmm9, [wys]            ; (450)
    mulsd xmm9, [zero_point_five]   ; (0.5 * height)

    cvtsi2sd xmm10, rdi             ; (y)
    cvtsi2sd xmm11, [wys]           ; (450)
    divsd xmm11, [two]              ; (450/2)
    subsd xmm10, xmm11              ; (y - 450/2)

    divsd xmm10, xmm9               ; zy = (y - 450/2) / (0.5 * 450)

    mov r8, r9                      ; iter = maxIter

iter_loop:
    movsd xmm13, xmm8                ; zx
    mulsd xmm13, xmm13               ; zx^2

    movsd xmm14, xmm10               ; zy
    mulsd xmm14, xmm14               ; zy^2

    movsd xmm15, xmm13               ; zx^2
    addsd xmm15, xmm14                ; zx^2 + zy^2
    comisd xmm15, [four]             ; zx^2 + zy^2 < 4
    jae end_iter_loop
    cmp r8, 0                       ; iter > 0
    jle end_iter_loop
        
        movsd xmm12, xmm13           ; zx * zx 
        subsd xmm12, xmm14           ; zx * zx - zy * zy
        addsd xmm12, xmm1			 ; tmp = zx * zx - zy * zy + realPart

        mulsd xmm10, [two]           ; 2 * zy
        mulsd xmm10, xmm8            ; 2 * zy * zx
        addsd xmm10, xmm2			 ; zy = 2 * zx * zy + imgPart

        movsd xmm8, xmm12            ; tmp -> zx
        
        dec r8                       ;--iter

        jmp iter_loop

end_iter_loop:
    ;mov rax, rdi ; rax = y
    ;imul rax, [szer] ; rax = y * width
    ;add rax, rsi ; rax = y * width + x
    ;mov [RSP+28 + rax * 4], r8d ; output[y * width + x] = iter

    mov [rcx + r11 * 4], r8
    inc r11

    ;mov r11, rdi ;+y
    ;imul r11, [szer] ;y* width
    ;add r11, rsi ;y * width + x
    ;mov [rcx + r11], r8

    ;cmp r13, 203070
    ;jge end_y_loop     ;do testów
    ;inc r13               

    inc rsi
    jmp x_loop

end_x_loop:
    inc rdi
	xor rsi, rsi
    jmp y_loop

end_y_loop:
    ret
    julia endp
    end
