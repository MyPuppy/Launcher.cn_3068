﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;

namespace RiderData
{
    public static class Emblem
    {
        public static void RmOwnerEmblemPacket()
        {
            using (OutPacket outPacket = new OutPacket("RmOwnerEmblemPacket"))
            {
                outPacket.WriteInt(1);
                outPacket.WriteInt(1);
                int Emblem = 614;
                outPacket.WriteInt(Emblem - 269);
                for (short i = 8196; i <= 8809; i++)
                {
                    if (i == 8197 || i == 8198 || i == 8199 || i == 8200 || i == 8201 || i == 8202 || i == 8203 || i == 8204 || i == 8205 || i == 8209 ||
                        i == 8210 || i == 8211 || i == 8212 || i == 8213 || i == 8214 || i == 8215 || i == 8216 || i == 8217 || i == 8219 || i == 8220 ||
                        i == 8221 || i == 8222 || i == 8223 || i == 8224 || i == 8225 || i == 8226 || i == 8227 || i == 8228 || i == 8229 || i == 8230 ||
                        i == 8231 || i == 8232 || i == 8233 || i == 8234 || i == 8235 || i == 8236 || i == 8237 || i == 8238 || i == 8239 || i == 8240 ||
                        i == 8241 || i == 8242 || i == 8243 || i == 8244 || i == 8245 || i == 8246 || i == 8247 || i == 8248 || i == 8249 || i == 8250 ||
                        i == 8251 || i == 8252 || i == 8253 || i == 8254 || i == 8255 || i == 8256 || i == 8257 || i == 8258 || i == 8261 || i == 8262 ||
                        i == 8263 || i == 8264 || i == 8265 || i == 8266 || i == 8267 || i == 8268 || i == 8269 || i == 8270 || i == 8271 || i == 8272 ||
                        i == 8273 || i == 8275 || i == 8276 || i == 8278 || i == 8279 || i == 8280 || i == 8281 || i == 8282 || i == 8283 || i == 8284 ||
                        i == 8285 || i == 8287 || i == 8288 || i == 8289 || i == 8290 || i == 8291 || i == 8292 || i == 8294 || i == 8295 || i == 8296 ||
                        i == 8297 || i == 8298 || i == 8299 || i == 8300 || i == 8308 || i == 8314 || i == 8316 || i == 8317 || i == 8318 || i == 8325 ||
                        i == 8326 || i == 8327 || i == 8328 || i == 8337 || i == 8341 || i == 8343 || i == 8344 || i == 8345 || i == 8346 || i == 8347 ||
                        i == 8350 || i == 8351 || i == 8352 || i == 8354 || i == 8357 || i == 8358 || i == 8361 || i == 8363 || i == 8369 || i == 8371 ||
                        i == 8372 || i == 8374 || i == 8376 || i == 8377 || i == 8378 || i == 8379 || i == 8382 || i == 8384 || i == 8385 || i == 8386 ||
                        i == 8387 || i == 8389 || i == 8391 || i == 8393 || i == 8394 || i == 8395 || i == 8397 || i == 8398 || i == 8399 || i == 8400 ||
                        i == 8401 || i == 8402 || i == 8404 || i == 8405 || i == 8406 || i == 8408 || i == 8411 || i == 8414 || i == 8416 || i == 8417 ||
                        i == 8421 || i == 8424 || i == 8427 || i == 8430 || i == 8437 || i == 8442 || i == 8449 || i == 8450 || i == 8452 || i == 8461 ||
                        i == 8467 || i == 8470 || i == 8476 || i == 8487 || i == 8498 || i == 8505 || i == 8506 || i == 8507 || i == 8508 || i == 8509 ||
                        i == 8514 || i == 8515 || i == 8516 || i == 8517 || i == 8518 || i == 8519 || i == 8522 || i == 8533 || i == 8534 || i == 8535 ||
                        i == 8536 || i == 8537 || i == 8538 || i == 8539 || i == 8540 || i == 8541 || i == 8542 || i == 8543 || i == 8544 || i == 8545 ||
                        i == 8554 || i == 8581 || i == 8602 || i == 8603 || i == 8604 || i == 8605 || i == 8606 || i == 8607 || i == 8608 || i == 8609 ||
                        i == 8610 || i == 8611 || i == 8612 || i == 8613 || i == 8614 || i == 8615 || i == 8616 || i == 8617 || i == 8618 || i == 8619 ||
                        i == 8655 || i == 8656 || i == 8657 || i == 8658 || i == 8659 || i == 8660 || i == 8661 || i == 8662 || i == 8663 || i == 8667 ||
                        i == 8673 || i == 8676 || i == 8677 || i == 8678 || i == 8679 || i == 8680 || i == 8681 || i == 8682 || i == 8683 || i == 8684 ||
                        i == 8685 || i == 8686 || i == 8687 || i == 8688 || i == 8689 || i == 8690 || i == 8694 || i == 8697 || i == 8698 || i == 8702 ||
                        i == 8703 || i == 8704 || i == 8705 || i == 8710 || i == 8712 || i == 8741 || i == 8742 || i == 8748 || i == 8750 || i == 8762 ||
                        i == 8766 || i == 8767 || i == 8768 || i == 8769 || i == 8770 || i == 8771 || i == 8772 || i == 8781 || i == 8788 || i == 8789 ||
                        i == 8790 || i == 8791 || i == 8793 || i == 8798 || i == 8799 || i == 8800 || i == 8801 || i == 8802 || i == 8803)
                    {
                    }
                    else
                    {
                        outPacket.WriteShort(i);
                    }
                }
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}